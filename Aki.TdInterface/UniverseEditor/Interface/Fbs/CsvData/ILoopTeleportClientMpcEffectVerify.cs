using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004907 RID: 18695
	public static class ILoopTeleportClientMpcEffectVerify
	{
		// Token: 0x0601D39B RID: 119707 RVA: 0x0041F7DF File Offset: 0x0041D9DF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
