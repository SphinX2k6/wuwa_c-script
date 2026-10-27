using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424C RID: 16972
	public static class IUseSkillCheckByFollowShooterSkillIdVerify
	{
		// Token: 0x060191A6 RID: 102822 RVA: 0x0039BFDC File Offset: 0x0039A1DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
