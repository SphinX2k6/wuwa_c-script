using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E72 RID: 28274
	public static class IRemoveTrialFollowShooterVerify
	{
		// Token: 0x06031F85 RID: 204677 RVA: 0x006C26B6 File Offset: 0x006C08B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
