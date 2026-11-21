using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B6 RID: 17334
	public class IParkourQuestConditionT
	{
		// Token: 0x17007760 RID: 30560
		// (get) Token: 0x06018985 RID: 100741 RVA: 0x00382598 File Offset: 0x00380798
		// (set) Token: 0x06018986 RID: 100742 RVA: 0x003825A0 File Offset: 0x003807A0
		public EChildQuest Type { get; set; }

		// Token: 0x17007761 RID: 30561
		// (get) Token: 0x06018987 RID: 100743 RVA: 0x003825A9 File Offset: 0x003807A9
		// (set) Token: 0x06018988 RID: 100744 RVA: 0x003825B1 File Offset: 0x003807B1
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007762 RID: 30562
		// (get) Token: 0x06018989 RID: 100745 RVA: 0x003825BA File Offset: 0x003807BA
		// (set) Token: 0x0601898A RID: 100746 RVA: 0x003825C2 File Offset: 0x003807C2
		public string Config { get; set; }

		// Token: 0x17007763 RID: 30563
		// (get) Token: 0x0601898B RID: 100747 RVA: 0x003825CB File Offset: 0x003807CB
		// (set) Token: 0x0601898C RID: 100748 RVA: 0x003825D3 File Offset: 0x003807D3
		public int SplineEntityId { get; set; }

		// Token: 0x17007764 RID: 30564
		// (get) Token: 0x0601898D RID: 100749 RVA: 0x003825DC File Offset: 0x003807DC
		// (set) Token: 0x0601898E RID: 100750 RVA: 0x003825E4 File Offset: 0x003807E4
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17007765 RID: 30565
		// (get) Token: 0x0601898F RID: 100751 RVA: 0x003825ED File Offset: 0x003807ED
		// (set) Token: 0x06018990 RID: 100752 RVA: 0x003825F5 File Offset: 0x003807F5
		public byte NullMask { get; set; }

		// Token: 0x06018991 RID: 100753 RVA: 0x003825FE File Offset: 0x003807FE
		public IParkourQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Config = null;
			this.SplineEntityId = 0;
			this.MatchRoleOption = null;
			this.NullMask = 0;
		}
	}
}
