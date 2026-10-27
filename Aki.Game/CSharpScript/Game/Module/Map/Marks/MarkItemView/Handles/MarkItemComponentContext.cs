using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Handles
{
	// Token: 0x0200552E RID: 21806
	[NullableContext(1)]
	[Nullable(0)]
	public class MarkItemComponentContext : IMarkItemComponentContext
	{
		// Token: 0x170085B3 RID: 34227
		// (get) Token: 0x06037AB8 RID: 228024 RVA: 0x00D368F5 File Offset: 0x00D34AF5
		// (set) Token: 0x06037AB9 RID: 228025 RVA: 0x00D368FD File Offset: 0x00D34AFD
		public MarkItemEntity MarkItemEntity { get; set; }

		// Token: 0x170085B4 RID: 34228
		// (get) Token: 0x06037ABA RID: 228026 RVA: 0x00D36906 File Offset: 0x00D34B06
		// (set) Token: 0x06037ABB RID: 228027 RVA: 0x00D3690E File Offset: 0x00D34B0E
		public UUISprite TopRightIconSprite { get; set; }

		// Token: 0x170085B5 RID: 34229
		// (get) Token: 0x06037ABC RID: 228028 RVA: 0x00D36917 File Offset: 0x00D34B17
		// (set) Token: 0x06037ABD RID: 228029 RVA: 0x00D3691F File Offset: 0x00D34B1F
		public TSetSpriteByPathAction SetSpriteByPathAction { get; set; }

		// Token: 0x170085B6 RID: 34230
		// (get) Token: 0x06037ABE RID: 228030 RVA: 0x00D36928 File Offset: 0x00D34B28
		// (set) Token: 0x06037ABF RID: 228031 RVA: 0x00D36930 File Offset: 0x00D34B30
		public UUIItem MarkComponentContainer { get; set; }

		// Token: 0x170085B7 RID: 34231
		// (get) Token: 0x06037AC0 RID: 228032 RVA: 0x00D36939 File Offset: 0x00D34B39
		// (set) Token: 0x06037AC1 RID: 228033 RVA: 0x00D36941 File Offset: 0x00D34B41
		public UUIItem MarkParentItem { get; set; }

		// Token: 0x170085B8 RID: 34232
		// (get) Token: 0x06037AC2 RID: 228034 RVA: 0x00D3694A File Offset: 0x00D34B4A
		// (set) Token: 0x06037AC3 RID: 228035 RVA: 0x00D36952 File Offset: 0x00D34B52
		public UUIItem MarkRootItem { get; set; }

		// Token: 0x170085B9 RID: 34233
		// (get) Token: 0x06037AC4 RID: 228036 RVA: 0x00D3695B File Offset: 0x00D34B5B
		// (set) Token: 0x06037AC5 RID: 228037 RVA: 0x00D36963 File Offset: 0x00D34B63
		public MarkItem MarkItem { get; set; }

		// Token: 0x06037AC6 RID: 228038 RVA: 0x00D3696C File Offset: 0x00D34B6C
		public bool CanExecuteComponentLogic()
		{
			return this.MarkItemEntity != null && (!this.MarkItem.IsDestroy || MapDefine.HasSingleComponentMarkType.Contains(this.MarkItem.MarkType));
		}
	}
}
