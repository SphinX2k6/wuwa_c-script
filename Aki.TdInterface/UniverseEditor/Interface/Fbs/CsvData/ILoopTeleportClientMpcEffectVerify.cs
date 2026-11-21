using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DA2 RID: 19874
	public static class ILoopTeleportClientMpcEffectVerify
	{
		// Token: 0x0601ED34 RID: 126260 RVA: 0x0044EF3F File Offset: 0x0044D13F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
