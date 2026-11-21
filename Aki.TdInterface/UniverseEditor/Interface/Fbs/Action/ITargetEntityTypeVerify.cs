using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B3B RID: 31547
	public static class ITargetEntityTypeVerify
	{
		// Token: 0x06038D0A RID: 232714 RVA: 0x007AEEA2 File Offset: 0x007AD0A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
