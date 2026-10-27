using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B0 RID: 18096
	public static class IStopCombatOperationCaptureVerify
	{
		// Token: 0x0601B7F0 RID: 112624 RVA: 0x003E737A File Offset: 0x003E557A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
