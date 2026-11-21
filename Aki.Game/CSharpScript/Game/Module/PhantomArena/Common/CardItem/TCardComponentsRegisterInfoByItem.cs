using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x0200419A RID: 16794
	[NullableContext(1)]
	[Nullable(0)]
	public class TCardComponentsRegisterInfoByItem
	{
		// Token: 0x17005572 RID: 21874
		// (get) Token: 0x0602A8A3 RID: 174243 RVA: 0x00C009DE File Offset: 0x00BFEBDE
		// (set) Token: 0x0602A8A4 RID: 174244 RVA: 0x00C009E6 File Offset: 0x00BFEBE6
		public ECardItemComponent ComponentType { get; set; }

		// Token: 0x17005573 RID: 21875
		// (get) Token: 0x0602A8A5 RID: 174245 RVA: 0x00C009EF File Offset: 0x00BFEBEF
		// (set) Token: 0x0602A8A6 RID: 174246 RVA: 0x00C009F7 File Offset: 0x00BFEBF7
		public UUIItem Item { get; set; }

		// Token: 0x0602A8A7 RID: 174247 RVA: 0x00C00A00 File Offset: 0x00BFEC00
		public TCardComponentsRegisterInfoByItem(ECardItemComponent componentType, UUIItem item)
		{
			this.ComponentType = componentType;
			this.Item = item;
		}

		// Token: 0x0602A8A8 RID: 174248 RVA: 0x00C00A16 File Offset: 0x00BFEC16
		public void Deconstruct(out ECardItemComponent componentType, out UUIItem item)
		{
			componentType = this.ComponentType;
			item = this.Item;
		}
	}
}
