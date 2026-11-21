using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B04 RID: 27396
	public class ICommonTipFirstCompleteT
	{
		// Token: 0x1700C933 RID: 51507
		// (get) Token: 0x0602F1A2 RID: 192930 RVA: 0x0066C9BF File Offset: 0x0066ABBF
		// (set) Token: 0x0602F1A3 RID: 192931 RVA: 0x0066C9C7 File Offset: 0x0066ABC7
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C934 RID: 51508
		// (get) Token: 0x0602F1A4 RID: 192932 RVA: 0x0066C9D0 File Offset: 0x0066ABD0
		// (set) Token: 0x0602F1A5 RID: 192933 RVA: 0x0066C9D8 File Offset: 0x0066ABD8
		public string TidText { get; set; }

		// Token: 0x0602F1A6 RID: 192934 RVA: 0x0066C9E1 File Offset: 0x0066ABE1
		public ICommonTipFirstCompleteT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidText = null;
		}
	}
}
