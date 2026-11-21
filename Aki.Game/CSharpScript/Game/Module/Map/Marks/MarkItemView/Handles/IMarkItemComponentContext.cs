using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x02004500 RID: 17664
	[NullableContext(1)]
	public interface IMarkItemComponentContext
	{
		// Token: 0x17005948 RID: 22856
		// (get) Token: 0x0602C979 RID: 182649
		// (set) Token: 0x0602C97A RID: 182650
		UUISprite TopRightIconSprite { get; set; }

		// Token: 0x17005949 RID: 22857
		// (get) Token: 0x0602C97B RID: 182651
		// (set) Token: 0x0602C97C RID: 182652
		TSetSpriteByPathAction SetSpriteByPathAction { get; set; }

		// Token: 0x1700594A RID: 22858
		// (get) Token: 0x0602C97D RID: 182653
		// (set) Token: 0x0602C97E RID: 182654
		UUIItem MarkComponentContainer { get; set; }

		// Token: 0x1700594B RID: 22859
		// (get) Token: 0x0602C97F RID: 182655
		// (set) Token: 0x0602C980 RID: 182656
		UUIItem MarkParentItem { get; set; }

		// Token: 0x1700594C RID: 22860
		// (get) Token: 0x0602C981 RID: 182657
		// (set) Token: 0x0602C982 RID: 182658
		UUIItem MarkRootItem { get; set; }

		// Token: 0x1700594D RID: 22861
		// (get) Token: 0x0602C983 RID: 182659
		// (set) Token: 0x0602C984 RID: 182660
		MarkItem MarkItem { get; set; }

		// Token: 0x0602C985 RID: 182661
		bool CanExecuteComponentLogic();
	}
}
