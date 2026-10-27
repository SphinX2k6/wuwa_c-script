using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF6 RID: 27638
	public static class IOpenConfirmBox2WithReturnVerify
	{
		// Token: 0x06030948 RID: 198984 RVA: 0x00698194 File Offset: 0x00696394
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

		// Token: 0x02007DCD RID: 32205
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013971 RID: 80241
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
