using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B8C RID: 31628
	public static class ITeleportTransitionTypeVerify
	{
		// Token: 0x06038F7F RID: 233343 RVA: 0x007B326E File Offset: 0x007B146E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
