using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200642F RID: 25647
	public static class ICloseSimpleGameplayVerify
	{
		// Token: 0x0602C623 RID: 181795 RVA: 0x00616ED0 File Offset: 0x006150D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICloseSimpleGameplayVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICloseSimpleGameplayVerify.<>O.<0>__Verify = new VerifyUnionAction(TCloseUiGameVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D28 RID: 32040
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013896 RID: 80022
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
