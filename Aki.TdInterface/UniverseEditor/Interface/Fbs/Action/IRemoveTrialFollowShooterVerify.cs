using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F6 RID: 30198
	public static class IRemoveTrialFollowShooterVerify
	{
		// Token: 0x06034FC5 RID: 217029 RVA: 0x0071E3EA File Offset: 0x0071C5EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
