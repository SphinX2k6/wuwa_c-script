using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764D RID: 30285
	public static class IResumeSystemRewardPopupTypeVerify
	{
		// Token: 0x06035238 RID: 217656 RVA: 0x007227D2 File Offset: 0x007209D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
