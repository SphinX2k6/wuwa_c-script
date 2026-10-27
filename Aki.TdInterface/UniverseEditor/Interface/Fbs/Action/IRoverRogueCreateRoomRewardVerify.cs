using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0B RID: 28427
	public static class IRoverRogueCreateRoomRewardVerify
	{
		// Token: 0x0603239B RID: 205723 RVA: 0x006C9272 File Offset: 0x006C7472
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
