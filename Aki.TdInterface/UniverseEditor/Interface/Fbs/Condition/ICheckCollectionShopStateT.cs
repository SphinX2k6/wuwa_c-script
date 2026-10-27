using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049AA RID: 18858
	public class ICheckCollectionShopStateT
	{
		// Token: 0x17008856 RID: 34902
		// (get) Token: 0x0601D6EE RID: 120558 RVA: 0x00425C24 File Offset: 0x00423E24
		// (set) Token: 0x0601D6EF RID: 120559 RVA: 0x00425C2C File Offset: 0x00423E2C
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008857 RID: 34903
		// (get) Token: 0x0601D6F0 RID: 120560 RVA: 0x00425C35 File Offset: 0x00423E35
		// (set) Token: 0x0601D6F1 RID: 120561 RVA: 0x00425C3D File Offset: 0x00423E3D
		public EShopType ShopType { get; set; }

		// Token: 0x0601D6F2 RID: 120562 RVA: 0x00425C46 File Offset: 0x00423E46
		public ICheckCollectionShopStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.ShopType = EShopType.ChengXiaoShan;
		}
	}
}
