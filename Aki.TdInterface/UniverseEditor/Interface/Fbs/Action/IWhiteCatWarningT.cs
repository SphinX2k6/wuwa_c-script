using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E13 RID: 32275
	public class IWhiteCatWarningT
	{
		// Token: 0x1700F1C0 RID: 61888
		// (get) Token: 0x0603A541 RID: 238913 RVA: 0x007DB8E7 File Offset: 0x007D9AE7
		// (set) Token: 0x0603A542 RID: 238914 RVA: 0x007DB8EF File Offset: 0x007D9AEF
		public ECommonTipType Type { get; set; }

		// Token: 0x1700F1C1 RID: 61889
		// (get) Token: 0x0603A543 RID: 238915 RVA: 0x007DB8F8 File Offset: 0x007D9AF8
		// (set) Token: 0x0603A544 RID: 238916 RVA: 0x007DB900 File Offset: 0x007D9B00
		public string WarningText { get; set; }

		// Token: 0x0603A545 RID: 238917 RVA: 0x007DB909 File Offset: 0x007D9B09
		public IWhiteCatWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
