using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040AE RID: 16558
	public static class IRhythmSpaceshipConditionStepInteractVerify
	{
		// Token: 0x060181E4 RID: 98788 RVA: 0x0037A24A File Offset: 0x0037844A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
