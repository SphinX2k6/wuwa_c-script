using System;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x0200534C RID: 21324
	public class MowingRiskConfigQualityData : IMowingRiskConfigQualityData
	{
		// Token: 0x1700674A RID: 26442
		// (get) Token: 0x060350F7 RID: 217335 RVA: 0x00ED2901 File Offset: 0x00ED0B01
		// (set) Token: 0x060350F8 RID: 217336 RVA: 0x00ED2909 File Offset: 0x00ED0B09
		public EMowingBuffQualityHexColor HexColor { get; set; }

		// Token: 0x1700674B RID: 26443
		// (get) Token: 0x060350F9 RID: 217337 RVA: 0x00ED2912 File Offset: 0x00ED0B12
		// (set) Token: 0x060350FA RID: 217338 RVA: 0x00ED291A File Offset: 0x00ED0B1A
		public InventoryDefine.EQuality CfgQualityInfoId { get; set; }

		// Token: 0x1700674C RID: 26444
		// (get) Token: 0x060350FB RID: 217339 RVA: 0x00ED2923 File Offset: 0x00ED0B23
		// (set) Token: 0x060350FC RID: 217340 RVA: 0x00ED292B File Offset: 0x00ED0B2B
		public EMowingBuffIntroduceQualityBackground BackgroundResource { get; set; }
	}
}
