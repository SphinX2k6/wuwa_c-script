using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD4 RID: 15060
	public static class ISystemVarBaseVerify
	{
		// Token: 0x060147D6 RID: 83926 RVA: 0x002FC036 File Offset: 0x002FA236
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
