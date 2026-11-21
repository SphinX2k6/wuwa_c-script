using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E79 RID: 24185
	public static class IRewardRefreshConfigVerify
	{
		// Token: 0x060287A7 RID: 165799 RVA: 0x00589198 File Offset: 0x00587398
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRewardRefreshConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRewardRefreshConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TRefreshConditionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IRewardRefreshConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRewardRefreshConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TRefreshRuleVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200847F RID: 33919
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401478A RID: 83850
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401478B RID: 83851
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
