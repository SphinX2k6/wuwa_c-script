using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AC RID: 17068
	public static class IWordArtResourceTypeVerify
	{
		// Token: 0x060194A6 RID: 103590 RVA: 0x003A1906 File Offset: 0x0039FB06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
