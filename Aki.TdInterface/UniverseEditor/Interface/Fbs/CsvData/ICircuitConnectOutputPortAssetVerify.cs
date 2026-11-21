using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D78 RID: 19832
	public static class ICircuitConnectOutputPortAssetVerify
	{
		// Token: 0x0601EBD8 RID: 125912 RVA: 0x0044C9AA File Offset: 0x0044ABAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
