using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B6E RID: 31598
	public static class ITeleportToAndEnterFishingBoatVerify
	{
		// Token: 0x06038E95 RID: 233109 RVA: 0x007B18FA File Offset: 0x007AFAFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
