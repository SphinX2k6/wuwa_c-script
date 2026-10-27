using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004045 RID: 16453
	public static class IQuestScheduleTypeVerify
	{
		// Token: 0x06017D27 RID: 97575 RVA: 0x0036FC62 File Offset: 0x0036DE62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
