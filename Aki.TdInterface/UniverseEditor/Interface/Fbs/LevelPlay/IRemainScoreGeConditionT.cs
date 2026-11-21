using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A8 RID: 18856
	public class IRemainScoreGeConditionT
	{
		// Token: 0x170083FE RID: 33790
		// (get) Token: 0x0601C282 RID: 115330 RVA: 0x003FA1A8 File Offset: 0x003F83A8
		// (set) Token: 0x0601C283 RID: 115331 RVA: 0x003FA1B0 File Offset: 0x003F83B0
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x170083FF RID: 33791
		// (get) Token: 0x0601C284 RID: 115332 RVA: 0x003FA1B9 File Offset: 0x003F83B9
		// (set) Token: 0x0601C285 RID: 115333 RVA: 0x003FA1C1 File Offset: 0x003F83C1
		public int Score { get; set; }

		// Token: 0x0601C286 RID: 115334 RVA: 0x003FA1CA File Offset: 0x003F83CA
		public IRemainScoreGeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
