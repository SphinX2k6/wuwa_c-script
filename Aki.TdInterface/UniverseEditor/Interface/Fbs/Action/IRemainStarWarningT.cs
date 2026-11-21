using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B6 RID: 30134
	public class IRemainStarWarningT
	{
		// Token: 0x1700DD90 RID: 56720
		// (get) Token: 0x06034DC4 RID: 216516 RVA: 0x0071AED3 File Offset: 0x007190D3
		// (set) Token: 0x06034DC5 RID: 216517 RVA: 0x0071AEDB File Offset: 0x007190DB
		public ECommonTipType Type { get; set; }

		// Token: 0x1700DD91 RID: 56721
		// (get) Token: 0x06034DC6 RID: 216518 RVA: 0x0071AEE4 File Offset: 0x007190E4
		// (set) Token: 0x06034DC7 RID: 216519 RVA: 0x0071AEEC File Offset: 0x007190EC
		public string WarningText { get; set; }

		// Token: 0x06034DC8 RID: 216520 RVA: 0x0071AEF5 File Offset: 0x007190F5
		public IRemainStarWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
