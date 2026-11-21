using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200692D RID: 26925
	public static class ICenterTextShowTypeVerify
	{
		// Token: 0x0602E257 RID: 189015 RVA: 0x0064E2EA File Offset: 0x0064C4EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
