using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064BA RID: 25786
	public class ICompleteGuideT
	{
		// Token: 0x1700BFDF RID: 49119
		// (get) Token: 0x0602CB74 RID: 183156 RVA: 0x00625587 File Offset: 0x00623787
		// (set) Token: 0x0602CB75 RID: 183157 RVA: 0x0062558F File Offset: 0x0062378F
		public EGuideTriggerType Type { get; set; }

		// Token: 0x1700BFE0 RID: 49120
		// (get) Token: 0x0602CB76 RID: 183158 RVA: 0x00625598 File Offset: 0x00623798
		// (set) Token: 0x0602CB77 RID: 183159 RVA: 0x006255A0 File Offset: 0x006237A0
		public List<ICondition2_UnionUnion> Conditions { get; set; }

		// Token: 0x1700BFE1 RID: 49121
		// (get) Token: 0x0602CB78 RID: 183160 RVA: 0x006255A9 File Offset: 0x006237A9
		// (set) Token: 0x0602CB79 RID: 183161 RVA: 0x006255B1 File Offset: 0x006237B1
		public int GuideId { get; set; }

		// Token: 0x1700BFE2 RID: 49122
		// (get) Token: 0x0602CB7A RID: 183162 RVA: 0x006255BA File Offset: 0x006237BA
		// (set) Token: 0x0602CB7B RID: 183163 RVA: 0x006255C2 File Offset: 0x006237C2
		public byte NullMask { get; set; }

		// Token: 0x0602CB7C RID: 183164 RVA: 0x006255CB File Offset: 0x006237CB
		public ICompleteGuideT()
		{
			this.Type = EGuideTriggerType.BeginnerGuide;
			this.Conditions = null;
			this.GuideId = 0;
			this.NullMask = 0;
		}
	}
}
