using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CDF RID: 31967
	public static class IUnlockTeleportTriggerVerify
	{
		// Token: 0x06039A9C RID: 236188 RVA: 0x007C75F6 File Offset: 0x007C57F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
