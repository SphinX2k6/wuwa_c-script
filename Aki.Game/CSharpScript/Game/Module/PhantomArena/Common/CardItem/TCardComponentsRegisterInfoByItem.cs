using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x020051CA RID: 20938
	[NullableContext(1)]
	[Nullable(0)]
	public class TCardComponentsRegisterInfoByItem
	{
		// Token: 0x170081B2 RID: 33202
		// (get) Token: 0x060359A8 RID: 219560 RVA: 0x00CB33A2 File Offset: 0x00CB15A2
		// (set) Token: 0x060359A9 RID: 219561 RVA: 0x00CB33AA File Offset: 0x00CB15AA
		public ECardItemComponent ComponentType { get; set; }

		// Token: 0x170081B3 RID: 33203
		// (get) Token: 0x060359AA RID: 219562 RVA: 0x00CB33B3 File Offset: 0x00CB15B3
		// (set) Token: 0x060359AB RID: 219563 RVA: 0x00CB33BB File Offset: 0x00CB15BB
		public UUIItem Item { get; set; }

		// Token: 0x060359AC RID: 219564 RVA: 0x00CB33C4 File Offset: 0x00CB15C4
		public TCardComponentsRegisterInfoByItem(ECardItemComponent componentType, UUIItem item)
		{
			this.ComponentType = componentType;
			this.Item = item;
		}

		// Token: 0x060359AD RID: 219565 RVA: 0x00CB33DA File Offset: 0x00CB15DA
		public void Deconstruct(out ECardItemComponent componentType, out UUIItem item)
		{
			componentType = this.ComponentType;
			item = this.Item;
		}
	}
}
