using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002CE RID: 718
	public class IDoubleViewBossStateViewStyle_SetValue
	{
		// Token: 0x04000C3B RID: 3131
		public EBossStateViewStyle Type;

		// Token: 0x04000C3C RID: 3132
		public EDoubleViewSlot Slot;

		// Token: 0x04000C3D RID: 3133
		[Nullable(2)]
		public IMarkMainStateTextTarget MainStateTextTarget;

		// Token: 0x04000C3E RID: 3134
		public int? BindMonsterEntityId;
	}
}
