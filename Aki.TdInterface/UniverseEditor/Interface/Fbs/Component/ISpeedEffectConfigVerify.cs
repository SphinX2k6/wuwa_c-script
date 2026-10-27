using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200597C RID: 22908
	public static class ISpeedEffectConfigVerify
	{
		// Token: 0x06026C74 RID: 158836 RVA: 0x00556771 File Offset: 0x00554971
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
