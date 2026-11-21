using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B19 RID: 27417
	public class ICommonTipTriggerDelegationT
	{
		// Token: 0x1700C959 RID: 51545
		// (get) Token: 0x0602F250 RID: 193104 RVA: 0x0066DA14 File Offset: 0x0066BC14
		// (set) Token: 0x0602F251 RID: 193105 RVA: 0x0066DA1C File Offset: 0x0066BC1C
		public ECommonTipType Type { get; set; }

		// Token: 0x1700C95A RID: 51546
		// (get) Token: 0x0602F252 RID: 193106 RVA: 0x0066DA25 File Offset: 0x0066BC25
		// (set) Token: 0x0602F253 RID: 193107 RVA: 0x0066DA2D File Offset: 0x0066BC2D
		public string TidMainText { get; set; }

		// Token: 0x1700C95B RID: 51547
		// (get) Token: 0x0602F254 RID: 193108 RVA: 0x0066DA36 File Offset: 0x0066BC36
		// (set) Token: 0x0602F255 RID: 193109 RVA: 0x0066DA3E File Offset: 0x0066BC3E
		public string TidSubText { get; set; }

		// Token: 0x0602F256 RID: 193110 RVA: 0x0066DA47 File Offset: 0x0066BC47
		public ICommonTipTriggerDelegationT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
