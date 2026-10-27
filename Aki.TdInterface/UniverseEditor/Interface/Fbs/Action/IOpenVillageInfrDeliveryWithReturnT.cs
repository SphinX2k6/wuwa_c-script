using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C49 RID: 27721
	public class IOpenVillageInfrDeliveryWithReturnT
	{
		// Token: 0x1700CE73 RID: 52851
		// (get) Token: 0x06030D5F RID: 200031 RVA: 0x006A2569 File Offset: 0x006A0769
		// (set) Token: 0x06030D60 RID: 200032 RVA: 0x006A2571 File Offset: 0x006A0771
		public ESystemType Type { get; set; }

		// Token: 0x1700CE74 RID: 52852
		// (get) Token: 0x06030D61 RID: 200033 RVA: 0x006A257A File Offset: 0x006A077A
		// (set) Token: 0x06030D62 RID: 200034 RVA: 0x006A2582 File Offset: 0x006A0782
		public TVillageInfrBuildTypeUnion DeliveryType { get; set; }

		// Token: 0x1700CE75 RID: 52853
		// (get) Token: 0x06030D63 RID: 200035 RVA: 0x006A258B File Offset: 0x006A078B
		// (set) Token: 0x06030D64 RID: 200036 RVA: 0x006A2593 File Offset: 0x006A0793
		public TVarRefUnion ReturnVar { get; set; }

		// Token: 0x06030D65 RID: 200037 RVA: 0x006A259C File Offset: 0x006A079C
		public IOpenVillageInfrDeliveryWithReturnT()
		{
			this.Type = ESystemType.Shop;
			this.DeliveryType = null;
			this.ReturnVar = null;
		}
	}
}
