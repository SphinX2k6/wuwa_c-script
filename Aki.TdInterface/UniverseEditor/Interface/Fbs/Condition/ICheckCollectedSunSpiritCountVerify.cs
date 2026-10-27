using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A8 RID: 18856
	public static class ICheckCollectedSunSpiritCountVerify
	{
		// Token: 0x0601D6DD RID: 120541 RVA: 0x004259E8 File Offset: 0x00423BE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
			{
				short typeIdVOffset = 14;
				short valueVOffset = 16;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckCollectedSunSpiritCountVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckCollectedSunSpiritCountVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A21 RID: 31265
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E4 RID: 78820
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
