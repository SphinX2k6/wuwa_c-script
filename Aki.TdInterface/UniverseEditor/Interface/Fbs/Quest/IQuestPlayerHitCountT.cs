using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004440 RID: 17472
	public class IQuestPlayerHitCountT
	{
		// Token: 0x17007922 RID: 31010
		// (get) Token: 0x060190CA RID: 102602 RVA: 0x00392CCE File Offset: 0x00390ECE
		// (set) Token: 0x060190CB RID: 102603 RVA: 0x00392CD6 File Offset: 0x00390ED6
		public EPlayerHitStatisticsType Type { get; set; }

		// Token: 0x17007923 RID: 31011
		// (get) Token: 0x060190CC RID: 102604 RVA: 0x00392CDF File Offset: 0x00390EDF
		// (set) Token: 0x060190CD RID: 102605 RVA: 0x00392CE7 File Offset: 0x00390EE7
		public float Cd { get; set; }

		// Token: 0x17007924 RID: 31012
		// (get) Token: 0x060190CE RID: 102606 RVA: 0x00392CF0 File Offset: 0x00390EF0
		// (set) Token: 0x060190CF RID: 102607 RVA: 0x00392CF8 File Offset: 0x00390EF8
		public List<int> EntityIds { get; set; }

		// Token: 0x17007925 RID: 31013
		// (get) Token: 0x060190D0 RID: 102608 RVA: 0x00392D01 File Offset: 0x00390F01
		// (set) Token: 0x060190D1 RID: 102609 RVA: 0x00392D09 File Offset: 0x00390F09
		public List<int> SkillIds { get; set; }

		// Token: 0x17007926 RID: 31014
		// (get) Token: 0x060190D2 RID: 102610 RVA: 0x00392D12 File Offset: 0x00390F12
		// (set) Token: 0x060190D3 RID: 102611 RVA: 0x00392D1A File Offset: 0x00390F1A
		public byte NullMask { get; set; }

		// Token: 0x060190D4 RID: 102612 RVA: 0x00392D23 File Offset: 0x00390F23
		public IQuestPlayerHitCountT()
		{
			this.Type = EPlayerHitStatisticsType.HitCount;
			this.Cd = 0f;
			this.EntityIds = null;
			this.SkillIds = null;
			this.NullMask = 0;
		}
	}
}
