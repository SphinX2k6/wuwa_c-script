using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073B0 RID: 29616
	public class IOpenVillageInfrDeliveryWithReturnT
	{
		// Token: 0x1700D98E RID: 55694
		// (get) Token: 0x06033CBA RID: 212154 RVA: 0x006FCA69 File Offset: 0x006FAC69
		// (set) Token: 0x06033CBB RID: 212155 RVA: 0x006FCA71 File Offset: 0x006FAC71
		public ESystemType Type { get; set; }

		// Token: 0x1700D98F RID: 55695
		// (get) Token: 0x06033CBC RID: 212156 RVA: 0x006FCA7A File Offset: 0x006FAC7A
		// (set) Token: 0x06033CBD RID: 212157 RVA: 0x006FCA82 File Offset: 0x006FAC82
		public TVillageInfrBuildTypeUnion DeliveryType { get; set; }

		// Token: 0x1700D990 RID: 55696
		// (get) Token: 0x06033CBE RID: 212158 RVA: 0x006FCA8B File Offset: 0x006FAC8B
		// (set) Token: 0x06033CBF RID: 212159 RVA: 0x006FCA93 File Offset: 0x006FAC93
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06033CC0 RID: 212160 RVA: 0x006FCA9C File Offset: 0x006FAC9C
		public IOpenVillageInfrDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.DeliveryType = null;
			this.ReturnVar = null;
		}
	}
}
