using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007334 RID: 29492
	public enum ITalkOptionParamType_Union : byte
	{
		// Token: 0x04012121 RID: 74017
		NONE,
		// Token: 0x04012122 RID: 74018
		ITalkOptionParamType,
		// Token: 0x04012123 RID: 74019
		ITalkOptionQteSucceed,
		// Token: 0x04012124 RID: 74020
		ITalkOptionQteFailed,
		// Token: 0x04012125 RID: 74021
		ITalkOptionQteSucceedDelayExec,
		// Token: 0x04012126 RID: 74022
		ITalkOptionQteFailedDelayExec,
		// Token: 0x04012127 RID: 74023
		ITalkOptionRogueRandomEvent,
		// Token: 0x04012128 RID: 74024
		ITalkOptionPhoneMessageEmoji,
		// Token: 0x04012129 RID: 74025
		ITalkOptionVisualNovel
	}
}
