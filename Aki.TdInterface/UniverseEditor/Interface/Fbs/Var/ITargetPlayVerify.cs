using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE6 RID: 15078
	public static class ITargetPlayVerify
	{
		// Token: 0x060148B3 RID: 84147 RVA: 0x002FDF02 File Offset: 0x002FC102
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
