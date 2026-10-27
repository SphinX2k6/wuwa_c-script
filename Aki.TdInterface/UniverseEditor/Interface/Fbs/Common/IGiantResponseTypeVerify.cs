using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC9 RID: 24009
	public static class IGiantResponseTypeVerify
	{
		// Token: 0x06029181 RID: 168321 RVA: 0x005A4056 File Offset: 0x005A2256
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
