using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F46 RID: 20294
	public static class ICheckInRangeProperlyConditionVerify
	{
		// Token: 0x0601F91A RID: 129306 RVA: 0x004644E8 File Offset: 0x004626E8
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

		// Token: 0x02008285 RID: 33413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014467 RID: 83047
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
