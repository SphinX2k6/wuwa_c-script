using System;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063CD RID: 25549
	public interface IMowingRiskConfigQualityData
	{
		// Token: 0x170093E5 RID: 37861
		// (get) Token: 0x06040430 RID: 263216
		// (set) Token: 0x06040431 RID: 263217
		EMowingBuffQualityHexColor HexColor { get; set; }

		// Token: 0x170093E6 RID: 37862
		// (get) Token: 0x06040432 RID: 263218
		// (set) Token: 0x06040433 RID: 263219
		InventoryDefine.EQuality CfgQualityInfoId { get; set; }

		// Token: 0x170093E7 RID: 37863
		// (get) Token: 0x06040434 RID: 263220
		// (set) Token: 0x06040435 RID: 263221
		EMowingBuffIntroduceQualityBackground BackgroundResource { get; set; }
	}
}
