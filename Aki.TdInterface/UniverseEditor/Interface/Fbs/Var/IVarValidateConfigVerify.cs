using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B22 RID: 15138
	public static class IVarValidateConfigVerify
	{
		// Token: 0x06014AB6 RID: 84662 RVA: 0x00301DE2 File Offset: 0x002FFFE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
