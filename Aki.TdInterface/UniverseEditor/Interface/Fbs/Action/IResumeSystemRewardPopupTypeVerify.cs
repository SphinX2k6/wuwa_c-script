using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC9 RID: 28361
	public static class IResumeSystemRewardPopupTypeVerify
	{
		// Token: 0x060321F8 RID: 205304 RVA: 0x006C6A9E File Offset: 0x006C4C9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
