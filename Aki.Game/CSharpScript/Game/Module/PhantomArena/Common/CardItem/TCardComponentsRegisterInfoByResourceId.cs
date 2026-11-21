using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem
{
	// Token: 0x0200419B RID: 16795
	[NullableContext(1)]
	[Nullable(0)]
	public class TCardComponentsRegisterInfoByResourceId
	{
		// Token: 0x17005574 RID: 21876
		// (get) Token: 0x0602A8A9 RID: 174249 RVA: 0x00C00A28 File Offset: 0x00BFEC28
		// (set) Token: 0x0602A8AA RID: 174250 RVA: 0x00C00A30 File Offset: 0x00BFEC30
		public ECardItemComponent ComponentType { get; set; }

		// Token: 0x17005575 RID: 21877
		// (get) Token: 0x0602A8AB RID: 174251 RVA: 0x00C00A39 File Offset: 0x00BFEC39
		// (set) Token: 0x0602A8AC RID: 174252 RVA: 0x00C00A41 File Offset: 0x00BFEC41
		public string ResourceId { get; set; }

		// Token: 0x17005576 RID: 21878
		// (get) Token: 0x0602A8AD RID: 174253 RVA: 0x00C00A4A File Offset: 0x00BFEC4A
		// (set) Token: 0x0602A8AE RID: 174254 RVA: 0x00C00A52 File Offset: 0x00BFEC52
		public UUIItem ParentItem { get; set; }

		// Token: 0x0602A8AF RID: 174255 RVA: 0x00C00A5B File Offset: 0x00BFEC5B
		public TCardComponentsRegisterInfoByResourceId(ECardItemComponent componentType, string resourceId, UUIItem parentItem)
		{
			this.ComponentType = componentType;
			this.ResourceId = resourceId;
			this.ParentItem = parentItem;
		}

		// Token: 0x0602A8B0 RID: 174256 RVA: 0x00C00A78 File Offset: 0x00BFEC78
		public void Deconstruct(out ECardItemComponent componentType, out string resourceId, out UUIItem parentItem)
		{
			componentType = this.ComponentType;
			resourceId = this.ResourceId;
			parentItem = this.ParentItem;
		}
	}
}
