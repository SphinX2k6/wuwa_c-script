using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7F RID: 7295
	public class INpcSwing_SetValue
	{
		// Token: 0x04005EDC RID: 24284
		public ENpcLeisureInteract Type;

		// Token: 0x04005EDD RID: 24285
		public bool? KeepState;

		// Token: 0x04005EDE RID: 24286
		public int TargetNpcId;

		// Token: 0x04005EDF RID: 24287
		[Nullable(1)]
		public string SwingDa;

		// Token: 0x04005EE0 RID: 24288
		public int EntityId;

		// Token: 0x04005EE1 RID: 24289
		public bool? SkipSitDown;
	}
}
