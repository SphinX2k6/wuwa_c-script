using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044FE RID: 17662
	public static class IRoleSkinTrialActivitiesVerify
	{
		// Token: 0x060198FC RID: 104700 RVA: 0x003A4F52 File Offset: 0x003A3152
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
