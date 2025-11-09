// SPDX-License-Identifier: MPL-2.0

using Robust.Client.UserInterface.Controls;

namespace Content.Client.Lobby.UI.Roles;

/// <summary>
/// Minimal expand/collapse buttons for trait categories.
/// </summary>
public sealed class TraitExpandCollapseButtons : BoxContainer
{
    public event Action<bool>? OnExpandCollapseAll;

    public TraitExpandCollapseButtons()
    {
        Orientation = LayoutOrientation.Horizontal;
        HorizontalAlignment = HAlignment.Center;

        var expandButton = new Button { Text = "Expand All" };
        expandButton.OnPressed += _ => OnExpandCollapseAll?.Invoke(true);
        AddChild(expandButton);

        var collapseButton = new Button { Text = "Collapse All" };
        collapseButton.OnPressed += _ => OnExpandCollapseAll?.Invoke(false);
        AddChild(collapseButton);
    }
}
