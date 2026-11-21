using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200466C RID: 18028
	public static class ITrackRuleFindFirstNotMatchStateVerify
	{
		// Token: 0x0601A74C RID: 108364 RVA: 0x003C440B File Offset: 0x003C260B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
