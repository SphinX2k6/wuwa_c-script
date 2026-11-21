using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A49 RID: 27209
	public static class IClientFollowShooterResetToPlayerVerify
	{
		// Token: 0x0602EABD RID: 191165 RVA: 0x0065C9D2 File Offset: 0x0065ABD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
