using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B1F RID: 15135
	public static class IVarTransformValidateConfigVerify
	{
		// Token: 0x06014AA4 RID: 84644 RVA: 0x00301C6A File Offset: 0x002FFE6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
