using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BEC RID: 31724
	public static class IToggleDragActorPlayTypeVerify
	{
		// Token: 0x060392FF RID: 234239 RVA: 0x007BA02A File Offset: 0x007B822A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
