using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D36 RID: 32054
	public static class IVillageInfrBuildOptionVerify
	{
		// Token: 0x06039DE5 RID: 237029 RVA: 0x007CE8FA File Offset: 0x007CCAFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
