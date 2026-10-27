using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B3 RID: 29875
	public static class IUiStyleGiantSubtitleOfLevelDVerify
	{
		// Token: 0x06036503 RID: 222467 RVA: 0x00761AF8 File Offset: 0x0075FCF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
