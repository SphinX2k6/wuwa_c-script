using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA5 RID: 19877
	public static class ILoopTeleportClientPlayEffectBaseVerify
	{
		// Token: 0x0601ED4C RID: 126284 RVA: 0x0044F173 File Offset: 0x0044D373
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
