using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000335 RID: 821
	public class IDynamicSpawnMonsterConfig_SetValue
	{
		// Token: 0x04000DB3 RID: 3507
		public int Id;

		// Token: 0x04000DB4 RID: 3508
		public float DelayTime;

		// Token: 0x04000DB5 RID: 3509
		public ISpawnMonsterCompleteCondition CompleteCondition;

		// Token: 0x04000DB6 RID: 3510
		public ISpawnMonsterPreDependOnPreceding PreCondition;

		// Token: 0x04000DB7 RID: 3511
		public float? Interval;

		// Token: 0x04000DB8 RID: 3512
		public IRandomPoolChoose MonsterChooseType;

		// Token: 0x04000DB9 RID: 3513
		public ISpawnMonsterPoint PointChooseType;
	}
}
