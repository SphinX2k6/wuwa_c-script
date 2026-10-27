using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006499 RID: 25753
	public class ICommonTipFirstCompleteT
	{
		// Token: 0x1700BFA6 RID: 49062
		// (get) Token: 0x0602CA28 RID: 182824 RVA: 0x00620DEB File Offset: 0x0061EFEB
		// (set) Token: 0x0602CA29 RID: 182825 RVA: 0x00620DF3 File Offset: 0x0061EFF3
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BFA7 RID: 49063
		// (get) Token: 0x0602CA2A RID: 182826 RVA: 0x00620DFC File Offset: 0x0061EFFC
		// (set) Token: 0x0602CA2B RID: 182827 RVA: 0x00620E04 File Offset: 0x0061F004
		public string TidText { get; set; }

		// Token: 0x0602CA2C RID: 182828 RVA: 0x00620E0D File Offset: 0x0061F00D
		public ICommonTipFirstCompleteT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidText = null;
		}
	}
}
