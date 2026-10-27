using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0E RID: 28430
	public static class IRoverRogueRoomFinishVerify
	{
		// Token: 0x060323A8 RID: 205736 RVA: 0x006C936A File Offset: 0x006C756A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
