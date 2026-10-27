using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EE RID: 750
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicSpawnMonsterConfig_SetValue
	{
		// Token: 0x04000CC9 RID: 3273
		public int Id;

		// Token: 0x04000CCA RID: 3274
		public float DelayTime;

		// Token: 0x04000CCB RID: 3275
		public ISpawnMonsterCompleteCondition CompleteCondition;

		// Token: 0x04000CCC RID: 3276
		public ISpawnMonsterPreDependOnPreceding PreCondition;

		// Token: 0x04000CCD RID: 3277
		public float? Interval;

		// Token: 0x04000CCE RID: 3278
		public IRandomPoolChoose MonsterChooseType;

		// Token: 0x04000CCF RID: 3279
		public ISpawnMonsterPoint PointChooseType;
	}
}
