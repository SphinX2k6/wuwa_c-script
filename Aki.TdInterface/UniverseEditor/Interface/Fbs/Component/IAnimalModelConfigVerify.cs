using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EAF RID: 20143
	public static class IAnimalModelConfigVerify
	{
		// Token: 0x0601FB89 RID: 129929 RVA: 0x0046A996 File Offset: 0x00468B96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
