using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007695 RID: 30357
	public static class IRoverRogueRoomFinishVerify
	{
		// Token: 0x06035400 RID: 218112 RVA: 0x007252D2 File Offset: 0x007234D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
