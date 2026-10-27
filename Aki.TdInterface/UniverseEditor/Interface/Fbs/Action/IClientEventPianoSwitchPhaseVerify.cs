using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A8 RID: 25512
	public static class IClientEventPianoSwitchPhaseVerify
	{
		// Token: 0x0602C224 RID: 180772 RVA: 0x0060F9F6 File Offset: 0x0060DBF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
