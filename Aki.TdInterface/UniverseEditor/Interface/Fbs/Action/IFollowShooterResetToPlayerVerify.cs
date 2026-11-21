using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE6 RID: 28390
	public static class IFollowShooterResetToPlayerVerify
	{
		// Token: 0x060311E2 RID: 201186 RVA: 0x006A8ABA File Offset: 0x006A6CBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
