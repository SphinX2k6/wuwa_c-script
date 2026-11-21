using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200449D RID: 17565
	public class IQuestStatisticsUseSkillT
	{
		// Token: 0x17007A04 RID: 31236
		// (get) Token: 0x060194E0 RID: 103648 RVA: 0x0039C8D1 File Offset: 0x0039AAD1
		// (set) Token: 0x060194E1 RID: 103649 RVA: 0x0039C8D9 File Offset: 0x0039AAD9
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007A05 RID: 31237
		// (get) Token: 0x060194E2 RID: 103650 RVA: 0x0039C8E2 File Offset: 0x0039AAE2
		// (set) Token: 0x060194E3 RID: 103651 RVA: 0x0039C8EA File Offset: 0x0039AAEA
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007A06 RID: 31238
		// (get) Token: 0x060194E4 RID: 103652 RVA: 0x0039C8F3 File Offset: 0x0039AAF3
		// (set) Token: 0x060194E5 RID: 103653 RVA: 0x0039C8FB File Offset: 0x0039AAFB
		public int SkillId { get; set; }

		// Token: 0x17007A07 RID: 31239
		// (get) Token: 0x060194E6 RID: 103654 RVA: 0x0039C904 File Offset: 0x0039AB04
		// (set) Token: 0x060194E7 RID: 103655 RVA: 0x0039C90C File Offset: 0x0039AB0C
		public bool IsWaitFinish { get; set; }

		// Token: 0x17007A08 RID: 31240
		// (get) Token: 0x060194E8 RID: 103656 RVA: 0x0039C915 File Offset: 0x0039AB15
		// (set) Token: 0x060194E9 RID: 103657 RVA: 0x0039C91D File Offset: 0x0039AB1D
		public byte NullMask { get; set; }

		// Token: 0x060194EA RID: 103658 RVA: 0x0039C926 File Offset: 0x0039AB26
		public IQuestStatisticsUseSkillT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.SkillId = 0;
			this.IsWaitFinish = false;
			this.NullMask = 0;
		}
	}
}
