using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E2D RID: 28205
	public static class IReignsCheckSettleVerify
	{
		// Token: 0x06031D5B RID: 204123 RVA: 0x006BEDBA File Offset: 0x006BCFBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
