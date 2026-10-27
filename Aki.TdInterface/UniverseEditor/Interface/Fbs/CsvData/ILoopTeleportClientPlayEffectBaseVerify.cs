using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x0200490A RID: 18698
	public static class ILoopTeleportClientPlayEffectBaseVerify
	{
		// Token: 0x0601D3B3 RID: 119731 RVA: 0x0041FA13 File Offset: 0x0041DC13
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
