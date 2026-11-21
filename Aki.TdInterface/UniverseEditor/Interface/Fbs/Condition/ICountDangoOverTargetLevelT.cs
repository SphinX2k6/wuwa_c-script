using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050DD RID: 20701
	public class ICountDangoOverTargetLevelT
	{
		// Token: 0x17009459 RID: 37977
		// (get) Token: 0x06020851 RID: 133201 RVA: 0x0048326A File Offset: 0x0048146A
		// (set) Token: 0x06020852 RID: 133202 RVA: 0x00483272 File Offset: 0x00481472
		public ECheckDangoCultivationProgressType Type { get; set; }

		// Token: 0x1700945A RID: 37978
		// (get) Token: 0x06020853 RID: 133203 RVA: 0x0048327B File Offset: 0x0048147B
		// (set) Token: 0x06020854 RID: 133204 RVA: 0x00483283 File Offset: 0x00481483
		public int TargetNumber { get; set; }

		// Token: 0x1700945B RID: 37979
		// (get) Token: 0x06020855 RID: 133205 RVA: 0x0048328C File Offset: 0x0048148C
		// (set) Token: 0x06020856 RID: 133206 RVA: 0x00483294 File Offset: 0x00481494
		public int TargetLevel { get; set; }

		// Token: 0x06020857 RID: 133207 RVA: 0x0048329D File Offset: 0x0048149D
		public ICountDangoOverTargetLevelT()
		{
			this.Type = ECheckDangoCultivationProgressType.CountDangoOverTargetLevel;
			this.TargetNumber = 0;
			this.TargetLevel = 0;
		}
	}
}
