using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001969 RID: 6505
	public class IDartGameplay_SetValue
	{
		// Token: 0x040056F3 RID: 22259
		public ESimpleGameplayType Type;

		// Token: 0x040056F4 RID: 22260
		public int MachineEntityId;

		// Token: 0x040056F5 RID: 22261
		[Nullable(1)]
		public IDartInteractTypeBase InteractType;
	}
}
