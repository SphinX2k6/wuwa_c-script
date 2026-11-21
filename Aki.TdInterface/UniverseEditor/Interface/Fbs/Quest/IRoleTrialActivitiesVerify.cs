using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200452B RID: 17707
	public static class IRoleTrialActivitiesVerify
	{
		// Token: 0x06019A1F RID: 104991 RVA: 0x003A6B4E File Offset: 0x003A4D4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
