using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A8 RID: 18088
	public static class IUseSkillCheckByFollowShooterSkillIdVerify
	{
		// Token: 0x0601A912 RID: 108818 RVA: 0x003C76B4 File Offset: 0x003C58B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
