using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200552D RID: 21805
	[NullableContext(1)]
	public interface IMarkItemComponentContext
	{
		// Token: 0x170085AC RID: 34220
		// (get) Token: 0x06037AA9 RID: 228009
		// (set) Token: 0x06037AAA RID: 228010
		MarkItemEntity MarkItemEntity { get; set; }

		// Token: 0x170085AD RID: 34221
		// (get) Token: 0x06037AAB RID: 228011
		// (set) Token: 0x06037AAC RID: 228012
		UUISprite TopRightIconSprite { get; set; }

		// Token: 0x170085AE RID: 34222
		// (get) Token: 0x06037AAD RID: 228013
		// (set) Token: 0x06037AAE RID: 228014
		TSetSpriteByPathAction SetSpriteByPathAction { get; set; }

		// Token: 0x170085AF RID: 34223
		// (get) Token: 0x06037AAF RID: 228015
		// (set) Token: 0x06037AB0 RID: 228016
		UUIItem MarkComponentContainer { get; set; }

		// Token: 0x170085B0 RID: 34224
		// (get) Token: 0x06037AB1 RID: 228017
		// (set) Token: 0x06037AB2 RID: 228018
		UUIItem MarkParentItem { get; set; }

		// Token: 0x170085B1 RID: 34225
		// (get) Token: 0x06037AB3 RID: 228019
		// (set) Token: 0x06037AB4 RID: 228020
		UUIItem MarkRootItem { get; set; }

		// Token: 0x170085B2 RID: 34226
		// (get) Token: 0x06037AB5 RID: 228021
		// (set) Token: 0x06037AB6 RID: 228022
		MarkItem MarkItem { get; set; }

		// Token: 0x06037AB7 RID: 228023
		bool CanExecuteComponentLogic();
	}
}
