using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007393 RID: 29587
	public static class IOpenSimpleGameplayVerify
	{
		// Token: 0x06033AD5 RID: 211669 RVA: 0x006F7A94 File Offset: 0x006F5C94
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

		// Token: 0x02008663 RID: 34403
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A42 RID: 84546
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
