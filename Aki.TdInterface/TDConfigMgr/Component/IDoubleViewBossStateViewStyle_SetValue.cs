using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000315 RID: 789
	public class IDoubleViewBossStateViewStyle_SetValue
	{
		// Token: 0x04000D25 RID: 3365
		public EBossStateViewStyle Type;

		// Token: 0x04000D26 RID: 3366
		public EDoubleViewSlot Slot;

		// Token: 0x04000D27 RID: 3367
		[Nullable(2)]
		public IMarkMainStateTextTarget MainStateTextTarget;

		// Token: 0x04000D28 RID: 3368
		public int? BindMonsterEntityId;
	}
}
