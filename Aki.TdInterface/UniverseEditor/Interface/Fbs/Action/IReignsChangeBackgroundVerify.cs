using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E27 RID: 28199
	public static class IReignsChangeBackgroundVerify
	{
		// Token: 0x06031D3A RID: 204090 RVA: 0x006BEB0F File Offset: 0x006BCD0F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
