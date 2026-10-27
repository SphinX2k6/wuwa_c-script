using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007345 RID: 29509
	public static class ITalkOptionQteFailedVerify
	{
		// Token: 0x060358D5 RID: 219349 RVA: 0x0074B406 File Offset: 0x00749606
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
