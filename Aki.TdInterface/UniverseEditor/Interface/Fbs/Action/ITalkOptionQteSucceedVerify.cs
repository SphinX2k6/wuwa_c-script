using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734B RID: 29515
	public static class ITalkOptionQteSucceedVerify
	{
		// Token: 0x060358F9 RID: 219385 RVA: 0x0074B6F6 File Offset: 0x007498F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
