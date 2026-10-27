using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004030 RID: 16432
	public static class IQuestScheduleNoneVerify
	{
		// Token: 0x06017C4B RID: 97355 RVA: 0x0036DDC6 File Offset: 0x0036BFC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
