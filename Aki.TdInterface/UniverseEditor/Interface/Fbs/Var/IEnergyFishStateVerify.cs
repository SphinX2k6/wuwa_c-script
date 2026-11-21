using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E7C RID: 15996
	public static class IEnergyFishStateVerify
	{
		// Token: 0x0601593D RID: 88381 RVA: 0x0031C32A File Offset: 0x0031A52A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
