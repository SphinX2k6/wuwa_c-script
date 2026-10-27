using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007387 RID: 29575
	public static class ITeleportToAndEnterFishingBoatVerify
	{
		// Token: 0x06035AFA RID: 219898 RVA: 0x0074F3BA File Offset: 0x0074D5BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
