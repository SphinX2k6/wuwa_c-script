using System;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200534B RID: 21323
	public interface IMowingRiskConfigQualityData
	{
		// Token: 0x17006747 RID: 26439
		// (get) Token: 0x060350F1 RID: 217329
		// (set) Token: 0x060350F2 RID: 217330
		EMowingBuffQualityHexColor HexColor { get; set; }

		// Token: 0x17006748 RID: 26440
		// (get) Token: 0x060350F3 RID: 217331
		// (set) Token: 0x060350F4 RID: 217332
		InventoryDefine.EQuality CfgQualityInfoId { get; set; }

		// Token: 0x17006749 RID: 26441
		// (get) Token: 0x060350F5 RID: 217333
		// (set) Token: 0x060350F6 RID: 217334
		EMowingBuffIntroduceQualityBackground BackgroundResource { get; set; }
	}
}
