using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE8 RID: 16360
	public static class IQuestFailedConditionPlayerMovementModeVerify
	{
		// Token: 0x060178C8 RID: 96456 RVA: 0x003655FC File Offset: 0x003637FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
