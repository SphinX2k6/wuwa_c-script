using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007402 RID: 29698
	public static class IToggleDragActorPlayTypeVerify
	{
		// Token: 0x06035F4C RID: 221004 RVA: 0x007578B6 File Offset: 0x00755AB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
