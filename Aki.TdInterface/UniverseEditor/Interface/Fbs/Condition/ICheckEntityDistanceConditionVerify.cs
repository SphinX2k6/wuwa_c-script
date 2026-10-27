using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049FF RID: 18943
	public static class ICheckEntityDistanceConditionVerify
	{
		// Token: 0x0601D9D1 RID: 121297 RVA: 0x0042AE38 File Offset: 0x00429038
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckEntityDistanceConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntityDistanceConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICheckEntityDistanceConditionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICheckEntityDistanceConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A2A RID: 31274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133ED RID: 78829
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
