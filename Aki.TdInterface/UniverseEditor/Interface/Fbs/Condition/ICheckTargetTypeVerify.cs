using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B55 RID: 19285
	public static class ICheckTargetTypeVerify
	{
		// Token: 0x0601E5FA RID: 124410 RVA: 0x004415E2 File Offset: 0x0043F7E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
