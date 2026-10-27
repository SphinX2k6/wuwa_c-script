using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E59 RID: 15961
	public static class IFlagChallengeSystemConfigVerify
	{
		// Token: 0x0601677C RID: 92028 RVA: 0x0033F8D8 File Offset: 0x0033DAD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlagChallengeSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlagChallengeSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFlagChallengeSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078E8 RID: 30952
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A0 RID: 78240
			public static VerifyTableAction <0>__Verify;
		}
	}
}
