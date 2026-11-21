using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004486 RID: 17542
	public static class IQuestScheduleTypeVerify
	{
		// Token: 0x060193C0 RID: 103360 RVA: 0x00399A56 File Offset: 0x00397C56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
