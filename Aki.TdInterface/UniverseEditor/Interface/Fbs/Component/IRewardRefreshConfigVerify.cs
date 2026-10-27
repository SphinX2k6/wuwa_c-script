using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200586C RID: 22636
	public static class IRewardRefreshConfigVerify
	{
		// Token: 0x06026245 RID: 156229 RVA: 0x0054264C File Offset: 0x0054084C
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

		// Token: 0x02007C10 RID: 31760
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136E8 RID: 79592
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040136E9 RID: 79593
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
