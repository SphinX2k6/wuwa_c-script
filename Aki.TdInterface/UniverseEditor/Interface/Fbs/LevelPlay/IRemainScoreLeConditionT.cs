using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049AB RID: 18859
	public class IRemainScoreLeConditionT
	{
		// Token: 0x17008403 RID: 33795
		// (get) Token: 0x0601C298 RID: 115352 RVA: 0x003FA3A8 File Offset: 0x003F85A8
		// (set) Token: 0x0601C299 RID: 115353 RVA: 0x003FA3B0 File Offset: 0x003F85B0
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17008404 RID: 33796
		// (get) Token: 0x0601C29A RID: 115354 RVA: 0x003FA3B9 File Offset: 0x003F85B9
		// (set) Token: 0x0601C29B RID: 115355 RVA: 0x003FA3C1 File Offset: 0x003F85C1
		public int Score { get; set; }

		// Token: 0x0601C29C RID: 115356 RVA: 0x003FA3CA File Offset: 0x003F85CA
		public IRemainScoreLeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
