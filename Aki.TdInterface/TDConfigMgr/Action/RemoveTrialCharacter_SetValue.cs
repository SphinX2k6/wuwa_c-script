using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002155 RID: 8533
	public class RemoveTrialCharacter_SetValue
	{
		// Token: 0x0400703C RID: 28732
		public int CharacterId;

		// Token: 0x0400703D RID: 28733
		[Nullable(1)]
		public List<int> CharacterGroup;

		// Token: 0x0400703E RID: 28734
		public bool? IsRemoveTips;

		// Token: 0x0400703F RID: 28735
		public bool? EnableSeamlessTeamSwitch;

		// Token: 0x04007040 RID: 28736
		public bool? OnlyLowMemoryDeviceExecute;
	}
}
