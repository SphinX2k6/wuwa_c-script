using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E9 RID: 29929
	public static class IUnlockTeleportTriggerVerify
	{
		// Token: 0x06036687 RID: 222855 RVA: 0x007643A6 File Offset: 0x007625A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
