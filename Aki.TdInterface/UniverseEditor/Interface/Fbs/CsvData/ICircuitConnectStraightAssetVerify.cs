using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D7E RID: 19838
	public static class ICircuitConnectStraightAssetVerify
	{
		// Token: 0x0601EBFC RID: 125948 RVA: 0x0044CC9A File Offset: 0x0044AE9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
