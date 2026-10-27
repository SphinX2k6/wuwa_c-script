using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E38 RID: 28216
	public class IRemainStarWarningT
	{
		// Token: 0x1700D241 RID: 53825
		// (get) Token: 0x06031DAE RID: 204206 RVA: 0x006BF54B File Offset: 0x006BD74B
		// (set) Token: 0x06031DAF RID: 204207 RVA: 0x006BF553 File Offset: 0x006BD753
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D242 RID: 53826
		// (get) Token: 0x06031DB0 RID: 204208 RVA: 0x006BF55C File Offset: 0x006BD75C
		// (set) Token: 0x06031DB1 RID: 204209 RVA: 0x006BF564 File Offset: 0x006BD764
		public string WarningText { get; set; }

		// Token: 0x06031DB2 RID: 204210 RVA: 0x006BF56D File Offset: 0x006BD76D
		public IRemainStarWarningT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.WarningText = null;
		}
	}
}
