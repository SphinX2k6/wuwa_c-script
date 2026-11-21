using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C01 RID: 31745
	public static class IToggleRideFlyingCarUiGameplayVerify
	{
		// Token: 0x06039385 RID: 234373 RVA: 0x007BAD5C File Offset: 0x007B8F5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IToggleRideFlyingCarUiGameplayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IToggleRideFlyingCarUiGameplayVerify.<>O.<0>__Verify = new VerifyUnionAction(TToggleRideFlyingCarUiGameplayVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008740 RID: 34624
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CC1 RID: 85185
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
