using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B6 RID: 9142
	public class RemoveTrialCharacter_SetValue
	{
		// Token: 0x04007671 RID: 30321
		public int CharacterId;

		// Token: 0x04007672 RID: 30322
		public List<int> CharacterGroup;

		// Token: 0x04007673 RID: 30323
		public bool? IsRemoveTips;

		// Token: 0x04007674 RID: 30324
		public bool? EnableSeamlessTeamSwitch;

		// Token: 0x04007675 RID: 30325
		public bool? OnlyLowMemoryDeviceExecute;
	}
}
