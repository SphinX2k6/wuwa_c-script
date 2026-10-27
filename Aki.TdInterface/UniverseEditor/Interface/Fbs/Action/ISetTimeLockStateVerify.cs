using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007096 RID: 28822
	public static class ISetTimeLockStateVerify
	{
		// Token: 0x0603309B RID: 209051 RVA: 0x006E25B6 File Offset: 0x006E07B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
