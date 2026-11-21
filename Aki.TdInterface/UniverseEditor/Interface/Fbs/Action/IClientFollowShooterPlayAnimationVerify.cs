using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A43 RID: 27203
	public static class IClientFollowShooterPlayAnimationVerify
	{
		// Token: 0x0602EA95 RID: 191125 RVA: 0x0065C64F File Offset: 0x0065A84F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
