using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F21 RID: 16161
	public static class IVarTransformValidateConfigVerify
	{
		// Token: 0x06015F4E RID: 89934 RVA: 0x00327EFA File Offset: 0x003260FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
