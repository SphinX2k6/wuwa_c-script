using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044AB RID: 17579
	public static class IEnrichmentItemVerify
	{
		// Token: 0x0601A419 RID: 107545 RVA: 0x003C02A4 File Offset: 0x003BE4A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
