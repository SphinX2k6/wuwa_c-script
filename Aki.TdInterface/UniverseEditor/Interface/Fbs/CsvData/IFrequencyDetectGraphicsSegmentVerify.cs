using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D8D RID: 19853
	public static class IFrequencyDetectGraphicsSegmentVerify
	{
		// Token: 0x0601EC90 RID: 126096 RVA: 0x0044DECD File Offset: 0x0044C0CD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfStrings(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
