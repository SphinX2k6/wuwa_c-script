using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000359 RID: 857
	public class IExploreSkillPullStatue_SetValue
	{
		// Token: 0x04000E26 RID: 3622
		public EExploreSkillInteractType Type;

		// Token: 0x04000E27 RID: 3623
		[Nullable(1)]
		public ICategoryMatchingCondition Condition;

		// Token: 0x04000E28 RID: 3624
		public int StatueInteractPointId;
	}
}
