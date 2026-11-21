using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BD0 RID: 19408
	public static class IPerformanceModeSettingVerify
	{
		// Token: 0x0601DA1D RID: 121373 RVA: 0x00428BE2 File Offset: 0x00426DE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
