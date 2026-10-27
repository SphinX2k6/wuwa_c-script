using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AAD RID: 15021
	public static class IParamsPresetVerify
	{
		// Token: 0x06014693 RID: 83603 RVA: 0x002F9C66 File Offset: 0x002F7E66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
