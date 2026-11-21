using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005740 RID: 22336
	public class IExploreSkillArrowInteractPointT
	{
		// Token: 0x1700A14B RID: 41291
		// (get) Token: 0x06023F10 RID: 147216 RVA: 0x004F0C1C File Offset: 0x004EEE1C
		// (set) Token: 0x06023F11 RID: 147217 RVA: 0x004F0C24 File Offset: 0x004EEE24
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700A14C RID: 41292
		// (get) Token: 0x06023F12 RID: 147218 RVA: 0x004F0C2D File Offset: 0x004EEE2D
		// (set) Token: 0x06023F13 RID: 147219 RVA: 0x004F0C35 File Offset: 0x004EEE35
		public float MinDistance { get; set; }

		// Token: 0x1700A14D RID: 41293
		// (get) Token: 0x06023F14 RID: 147220 RVA: 0x004F0C3E File Offset: 0x004EEE3E
		// (set) Token: 0x06023F15 RID: 147221 RVA: 0x004F0C46 File Offset: 0x004EEE46
		public float InteractWaitTime { get; set; }

		// Token: 0x1700A14E RID: 41294
		// (get) Token: 0x06023F16 RID: 147222 RVA: 0x004F0C4F File Offset: 0x004EEE4F
		// (set) Token: 0x06023F17 RID: 147223 RVA: 0x004F0C57 File Offset: 0x004EEE57
		public float ShootWaitTime { get; set; }

		// Token: 0x06023F18 RID: 147224 RVA: 0x004F0C60 File Offset: 0x004EEE60
		public IExploreSkillArrowInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.MinDistance = 0f;
			this.InteractWaitTime = 0f;
			this.ShootWaitTime = 0f;
		}
	}
}
