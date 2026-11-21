using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735A RID: 29530
	public static class IOpenConfirmBox2WithReturnVerify
	{
		// Token: 0x06033868 RID: 211048 RVA: 0x006F1B28 File Offset: 0x006EFD28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenConfirmBox2WithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenConfirmBox2WithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008656 RID: 34390
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A32 RID: 84530
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
