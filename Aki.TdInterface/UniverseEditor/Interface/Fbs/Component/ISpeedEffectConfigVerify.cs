using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F89 RID: 24457
	public static class ISpeedEffectConfigVerify
	{
		// Token: 0x060291DE RID: 168414 RVA: 0x0059D3DD File Offset: 0x0059B5DD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
