using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007677 RID: 30327
	public static class IRogueSelectRoomTypeVerify
	{
		// Token: 0x06035350 RID: 217936 RVA: 0x0072426A File Offset: 0x0072246A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
