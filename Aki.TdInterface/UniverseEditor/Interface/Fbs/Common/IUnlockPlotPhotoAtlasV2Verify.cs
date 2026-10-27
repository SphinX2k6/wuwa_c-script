using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E6B RID: 24171
	public static class IUnlockPlotPhotoAtlasV2Verify
	{
		// Token: 0x06029656 RID: 169558 RVA: 0x005AC6FC File Offset: 0x005AA8FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
