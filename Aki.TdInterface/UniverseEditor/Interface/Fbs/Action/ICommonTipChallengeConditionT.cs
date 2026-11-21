using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AF8 RID: 27384
	public class ICommonTipChallengeConditionT
	{
		// Token: 0x1700C91E RID: 51486
		// (get) Token: 0x0602F140 RID: 192832 RVA: 0x0066C0CC File Offset: 0x0066A2CC
		// (set) Token: 0x0602F141 RID: 192833 RVA: 0x0066C0D4 File Offset: 0x0066A2D4
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C91F RID: 51487
		// (get) Token: 0x0602F142 RID: 192834 RVA: 0x0066C0DD File Offset: 0x0066A2DD
		// (set) Token: 0x0602F143 RID: 192835 RVA: 0x0066C0E5 File Offset: 0x0066A2E5
		public string TidMainText { get; set; }

		// Token: 0x1700C920 RID: 51488
		// (get) Token: 0x0602F144 RID: 192836 RVA: 0x0066C0EE File Offset: 0x0066A2EE
		// (set) Token: 0x0602F145 RID: 192837 RVA: 0x0066C0F6 File Offset: 0x0066A2F6
		public string TidSubText { get; set; }

		// Token: 0x0602F146 RID: 192838 RVA: 0x0066C0FF File Offset: 0x0066A2FF
		public ICommonTipChallengeConditionT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
