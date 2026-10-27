using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FC RID: 29692
	public static class IToggleDragActorPlayDisableVerify
	{
		// Token: 0x06035F06 RID: 220934 RVA: 0x007570AE File Offset: 0x007552AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
