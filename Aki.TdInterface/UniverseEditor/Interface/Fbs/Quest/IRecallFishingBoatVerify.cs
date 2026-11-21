using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044DA RID: 17626
	public static class IRecallFishingBoatVerify
	{
		// Token: 0x060197CD RID: 104397 RVA: 0x003A2962 File Offset: 0x003A0B62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
