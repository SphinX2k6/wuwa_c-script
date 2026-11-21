using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D69 RID: 19817
	public static class ICircuitConnectAssetBaseVerify
	{
		// Token: 0x0601EB64 RID: 125796 RVA: 0x0044BC56 File Offset: 0x00449E56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
