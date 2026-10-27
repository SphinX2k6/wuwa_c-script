using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542D RID: 21549
	public static class IInitStateWuYinQuVerify
	{
		// Token: 0x06023668 RID: 145000 RVA: 0x004E5DE6 File Offset: 0x004E3FE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
