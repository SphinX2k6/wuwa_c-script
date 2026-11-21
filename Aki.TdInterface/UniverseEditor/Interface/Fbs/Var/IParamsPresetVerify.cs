using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EAF RID: 16047
	public static class IParamsPresetVerify
	{
		// Token: 0x06015B39 RID: 88889 RVA: 0x0031FE72 File Offset: 0x0031E072
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
