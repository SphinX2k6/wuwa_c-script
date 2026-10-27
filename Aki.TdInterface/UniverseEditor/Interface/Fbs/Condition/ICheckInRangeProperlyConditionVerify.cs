using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A80 RID: 19072
	public static class ICheckInRangeProperlyConditionVerify
	{
		// Token: 0x0601DE77 RID: 122487 RVA: 0x0043335C File Offset: 0x0043155C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckInRangeProperlyConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckInRangeProperlyConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A35 RID: 31285
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F9 RID: 78841
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
