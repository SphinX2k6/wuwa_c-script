using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BE RID: 29118
	public static class IMechStuntHighSpeedVerify
	{
		// Token: 0x06032A65 RID: 207461 RVA: 0x006D7DBE File Offset: 0x006D5FBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
