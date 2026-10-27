using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063E4 RID: 25572
	public static class IClientSendTagEventToControlCharacterVerify
	{
		// Token: 0x0602C3E2 RID: 181218 RVA: 0x00612B7F File Offset: 0x00610D7F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
