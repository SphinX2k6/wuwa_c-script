using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056BE RID: 22206
	[Flags]
	public enum EItemVisualState
	{
		// Token: 0x0401CFD1 RID: 118737
		None = 0,
		// Token: 0x0401CFD2 RID: 118738
		Selected = 1,
		// Token: 0x0401CFD3 RID: 118739
		Floating = 2,
		// Token: 0x0401CFD4 RID: 118740
		InLayerMode = 4,
		// Token: 0x0401CFD5 RID: 118741
		DragOther = 8,
		// Token: 0x0401CFD6 RID: 118742
		Dragging = 16,
		// Token: 0x0401CFD7 RID: 118743
		Hovered = 32
	}
}
