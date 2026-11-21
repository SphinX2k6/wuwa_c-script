using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D7B RID: 19835
	public static class ICircuitConnectPowerPortAssetVerify
	{
		// Token: 0x0601EBEA RID: 125930 RVA: 0x0044CB22 File Offset: 0x0044AD22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
