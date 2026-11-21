using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004294 RID: 17044
	public static class IFlagChallengeSystemConfigVerify
	{
		// Token: 0x06017DA3 RID: 97699 RVA: 0x00368408 File Offset: 0x00366608
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

		// Token: 0x0200812E RID: 33070
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141FE RID: 82430
			public static VerifyTableAction <0>__Verify;
		}
	}
}
