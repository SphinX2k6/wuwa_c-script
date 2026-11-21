using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E02 RID: 28162
	public static class IFadeBackgroundTypeVerify
	{
		// Token: 0x060309E8 RID: 199144 RVA: 0x00699BAA File Offset: 0x00697DAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
