using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051CB RID: 20939
	[NullableContext(1)]
	[Nullable(0)]
	public class TCardComponentsRegisterInfoByResourceId
	{
		// Token: 0x170081B4 RID: 33204
		// (get) Token: 0x060359AE RID: 219566 RVA: 0x00CB33EC File Offset: 0x00CB15EC
		// (set) Token: 0x060359AF RID: 219567 RVA: 0x00CB33F4 File Offset: 0x00CB15F4
		public ECardItemComponent ComponentType { get; set; }

		// Token: 0x170081B5 RID: 33205
		// (get) Token: 0x060359B0 RID: 219568 RVA: 0x00CB33FD File Offset: 0x00CB15FD
		// (set) Token: 0x060359B1 RID: 219569 RVA: 0x00CB3405 File Offset: 0x00CB1605
		public string ResourceId { get; set; }

		// Token: 0x170081B6 RID: 33206
		// (get) Token: 0x060359B2 RID: 219570 RVA: 0x00CB340E File Offset: 0x00CB160E
		// (set) Token: 0x060359B3 RID: 219571 RVA: 0x00CB3416 File Offset: 0x00CB1616
		public UUIItem ParentItem { get; set; }

		// Token: 0x060359B4 RID: 219572 RVA: 0x00CB341F File Offset: 0x00CB161F
		public TCardComponentsRegisterInfoByResourceId(ECardItemComponent componentType, string resourceId, UUIItem parentItem)
		{
			this.ComponentType = componentType;
			this.ResourceId = resourceId;
			this.ParentItem = parentItem;
		}

		// Token: 0x060359B5 RID: 219573 RVA: 0x00CB343C File Offset: 0x00CB163C
		public void Deconstruct(out ECardItemComponent componentType, out string resourceId, out UUIItem parentItem)
		{
			componentType = this.ComponentType;
			resourceId = this.ResourceId;
			parentItem = this.ParentItem;
		}
	}
}
