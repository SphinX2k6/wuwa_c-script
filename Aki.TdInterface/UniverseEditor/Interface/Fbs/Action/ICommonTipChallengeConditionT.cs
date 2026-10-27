using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200648D RID: 25741
	public class ICommonTipChallengeConditionT
	{
		// Token: 0x1700BF91 RID: 49041
		// (get) Token: 0x0602C9C6 RID: 182726 RVA: 0x006204F8 File Offset: 0x0061E6F8
		// (set) Token: 0x0602C9C7 RID: 182727 RVA: 0x00620500 File Offset: 0x0061E700
		public ECommonTipType Type { get; set; }

		// Token: 0x1700BF92 RID: 49042
		// (get) Token: 0x0602C9C8 RID: 182728 RVA: 0x00620509 File Offset: 0x0061E709
		// (set) Token: 0x0602C9C9 RID: 182729 RVA: 0x00620511 File Offset: 0x0061E711
		public string TidMainText { get; set; }

		// Token: 0x1700BF93 RID: 49043
		// (get) Token: 0x0602C9CA RID: 182730 RVA: 0x0062051A File Offset: 0x0061E71A
		// (set) Token: 0x0602C9CB RID: 182731 RVA: 0x00620522 File Offset: 0x0061E722
		public string TidSubText { get; set; }

		// Token: 0x0602C9CC RID: 182732 RVA: 0x0062052B File Offset: 0x0061E72B
		public ICommonTipChallengeConditionT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
