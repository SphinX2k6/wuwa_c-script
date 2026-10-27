using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200676E RID: 26478
	[Flags]
	public enum EItemVisualState
	{
		// Token: 0x04022774 RID: 141172
		None = 0,
		// Token: 0x04022775 RID: 141173
		Selected = 1,
		// Token: 0x04022776 RID: 141174
		Floating = 2,
		// Token: 0x04022777 RID: 141175
		InLayerMode = 4,
		// Token: 0x04022778 RID: 141176
		DragOther = 8,
		// Token: 0x04022779 RID: 141177
		Dragging = 16,
		// Token: 0x0402277A RID: 141178
		Hovered = 32
	}
}
