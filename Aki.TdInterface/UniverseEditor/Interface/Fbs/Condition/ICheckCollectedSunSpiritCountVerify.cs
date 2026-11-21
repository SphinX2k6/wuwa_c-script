using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E5F RID: 20063
	public static class ICheckCollectedSunSpiritCountVerify
	{
		// Token: 0x0601F102 RID: 127234 RVA: 0x00455E9C File Offset: 0x0045409C
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

		// Token: 0x02008270 RID: 33392
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014451 RID: 83025
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
