using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A7D RID: 19069
	public static class ICheckInRangeConditionVerify
	{
		// Token: 0x0601DE4D RID: 122445 RVA: 0x00432D98 File Offset: 0x00430F98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckInRangeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckInRangeConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A34 RID: 31284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F8 RID: 78840
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
