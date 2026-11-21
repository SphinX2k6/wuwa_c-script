using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200735D RID: 29533
	public static class IOpenConfirmBoxWithReturnVerify
	{
		// Token: 0x06033889 RID: 211081 RVA: 0x006F2044 File Offset: 0x006F0244
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenConfirmBoxWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenConfirmBoxWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008657 RID: 34391
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A33 RID: 84531
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
