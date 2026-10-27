using System;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063CE RID: 25550
	public class MowingRiskConfigQualityData : IMowingRiskConfigQualityData
	{
		// Token: 0x170093E8 RID: 37864
		// (get) Token: 0x06040436 RID: 263222 RVA: 0x00F8B969 File Offset: 0x00F89B69
		// (set) Token: 0x06040437 RID: 263223 RVA: 0x00F8B971 File Offset: 0x00F89B71
		public EMowingBuffQualityHexColor HexColor { get; set; }

		// Token: 0x170093E9 RID: 37865
		// (get) Token: 0x06040438 RID: 263224 RVA: 0x00F8B97A File Offset: 0x00F89B7A
		// (set) Token: 0x06040439 RID: 263225 RVA: 0x00F8B982 File Offset: 0x00F89B82
		public InventoryDefine.EQuality CfgQualityInfoId { get; set; }

		// Token: 0x170093EA RID: 37866
		// (get) Token: 0x0604043A RID: 263226 RVA: 0x00F8B98B File Offset: 0x00F89B8B
		// (set) Token: 0x0604043B RID: 263227 RVA: 0x00F8B993 File Offset: 0x00F89B93
		public EMowingBuffIntroduceQualityBackground BackgroundResource { get; set; }
	}
}
