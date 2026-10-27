using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC9 RID: 15817
	public static class IDangoAbyssInformationViewVerify
	{
		// Token: 0x0601612C RID: 90412 RVA: 0x00330FD2 File Offset: 0x0032F1D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
