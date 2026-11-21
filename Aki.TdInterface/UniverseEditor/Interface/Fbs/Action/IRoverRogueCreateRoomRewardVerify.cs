using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007692 RID: 30354
	public static class IRoverRogueCreateRoomRewardVerify
	{
		// Token: 0x060353F3 RID: 218099 RVA: 0x007251DA File Offset: 0x007233DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
