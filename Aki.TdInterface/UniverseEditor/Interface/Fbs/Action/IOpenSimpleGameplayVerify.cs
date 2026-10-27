using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2C RID: 27692
	public static class IOpenSimpleGameplayVerify
	{
		// Token: 0x06030B7E RID: 199550 RVA: 0x0069D684 File Offset: 0x0069B884
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenSimpleGameplayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSimpleGameplayVerify.<>O.<0>__Verify = new VerifyUnionAction(TUiGameVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DD9 RID: 32217
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013980 RID: 80256
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
