using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005463 RID: 21603
	public static class IInteractPlayerDiractionTypeVerify
	{
		// Token: 0x060238A6 RID: 145574 RVA: 0x004EA842 File Offset: 0x004E8A42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
