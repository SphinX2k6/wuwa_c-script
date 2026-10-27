using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AFF RID: 27391
	public static class IMontageIdVerify
	{
		// Token: 0x06030095 RID: 196757 RVA: 0x00687E6C File Offset: 0x0068606C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
