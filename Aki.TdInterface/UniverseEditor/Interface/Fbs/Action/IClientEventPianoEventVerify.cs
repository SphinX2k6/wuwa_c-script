using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A2 RID: 25506
	public static class IClientEventPianoEventVerify
	{
		// Token: 0x0602C204 RID: 180740 RVA: 0x0060F736 File Offset: 0x0060D936
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
