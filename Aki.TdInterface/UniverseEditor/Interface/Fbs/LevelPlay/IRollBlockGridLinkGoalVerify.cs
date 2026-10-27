using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200457A RID: 17786
	public static class IRollBlockGridLinkGoalVerify
	{
		// Token: 0x0601ADB6 RID: 110006 RVA: 0x003D54F0 File Offset: 0x003D36F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridLinkGoalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridLinkGoalVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C0 RID: 31168
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401335B RID: 78683
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
