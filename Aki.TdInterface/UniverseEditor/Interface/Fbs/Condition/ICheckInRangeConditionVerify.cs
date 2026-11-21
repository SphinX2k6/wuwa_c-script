using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F43 RID: 20291
	public static class ICheckInRangeConditionVerify
	{
		// Token: 0x0601F8F0 RID: 129264 RVA: 0x00463F24 File Offset: 0x00462124
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

		// Token: 0x02008284 RID: 33412
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014466 RID: 83046
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
