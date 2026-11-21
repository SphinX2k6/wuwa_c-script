using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D8 RID: 21464
	public static class IAnimalModelConfigVerify
	{
		// Token: 0x0602188A RID: 137354 RVA: 0x0049FE12 File Offset: 0x0049E012
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
