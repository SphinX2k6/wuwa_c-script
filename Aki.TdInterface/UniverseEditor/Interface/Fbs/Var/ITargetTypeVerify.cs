using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE9 RID: 15081
	public static class ITargetTypeVerify
	{
		// Token: 0x060148C5 RID: 84165 RVA: 0x002FE07A File Offset: 0x002FC27A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
