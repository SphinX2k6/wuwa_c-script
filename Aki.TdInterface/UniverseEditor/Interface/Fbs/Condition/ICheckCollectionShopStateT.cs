using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E64 RID: 20068
	public class ICheckCollectionShopStateT
	{
		// Token: 0x17008F18 RID: 36632
		// (get) Token: 0x0601F12D RID: 127277 RVA: 0x0045636C File Offset: 0x0045456C
		// (set) Token: 0x0601F12E RID: 127278 RVA: 0x00456374 File Offset: 0x00454574
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008F19 RID: 36633
		// (get) Token: 0x0601F12F RID: 127279 RVA: 0x0045637D File Offset: 0x0045457D
		// (set) Token: 0x0601F130 RID: 127280 RVA: 0x00456385 File Offset: 0x00454585
		public EShopType ShopType { get; set; }

		// Token: 0x0601F131 RID: 127281 RVA: 0x0045638E File Offset: 0x0045458E
		public ICheckCollectionShopStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.ShopType = EShopType.ChengXiaoShan;
		}
	}
}
