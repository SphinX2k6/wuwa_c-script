using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B10 RID: 15120
	public static class IVarPrefabValidateConfigVerify
	{
		// Token: 0x06014A38 RID: 84536 RVA: 0x0030123E File Offset: 0x002FF43E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
