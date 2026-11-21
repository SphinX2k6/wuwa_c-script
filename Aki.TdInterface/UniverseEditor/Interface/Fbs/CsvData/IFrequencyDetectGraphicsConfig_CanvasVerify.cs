using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D87 RID: 19847
	public static class IFrequencyDetectGraphicsConfig_CanvasVerify
	{
		// Token: 0x0601EC56 RID: 126038 RVA: 0x0044D788 File Offset: 0x0044B988
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
