using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2A RID: 28202
	public static class IReignsChangePlayerNameVerify
	{
		// Token: 0x06031D4E RID: 204110 RVA: 0x006BECC9 File Offset: 0x006BCEC9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
