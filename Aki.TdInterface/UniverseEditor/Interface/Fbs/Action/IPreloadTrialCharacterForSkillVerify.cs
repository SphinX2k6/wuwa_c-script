using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DA3 RID: 28067
	public static class IPreloadTrialCharacterForSkillVerify
	{
		// Token: 0x0603195A RID: 203098 RVA: 0x006B8468 File Offset: 0x006B6668
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreloadTrialCharacterForSkillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreloadTrialCharacterForSkillVerify.<>O.<0>__Verify = new VerifyTableAction(ICharacterGroupNewVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E06 RID: 32262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C1 RID: 80321
			public static VerifyTableAction <0>__Verify;
		}
	}
}
