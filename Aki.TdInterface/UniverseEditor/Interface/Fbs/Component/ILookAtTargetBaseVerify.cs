using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A97 RID: 23191
	public static class ILookAtTargetBaseVerify
	{
		// Token: 0x06026040 RID: 155712 RVA: 0x00535DAE File Offset: 0x00533FAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
