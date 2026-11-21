using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FF RID: 28927
	public static class ILiveInteractDanmakuTriggerVerify
	{
		// Token: 0x060323DA RID: 205786 RVA: 0x006CB7E6 File Offset: 0x006C99E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
