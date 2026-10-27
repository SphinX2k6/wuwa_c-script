using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005068 RID: 20584
	public static class ICycleModeTypeVerify
	{
		// Token: 0x06020FDA RID: 135130 RVA: 0x0049587A File Offset: 0x00493A7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
