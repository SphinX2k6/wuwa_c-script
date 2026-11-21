using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044EF RID: 17647
	public static class IRhythmSpaceshipConditionStepInteractVerify
	{
		// Token: 0x06019885 RID: 104581 RVA: 0x003A419A File Offset: 0x003A239A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
