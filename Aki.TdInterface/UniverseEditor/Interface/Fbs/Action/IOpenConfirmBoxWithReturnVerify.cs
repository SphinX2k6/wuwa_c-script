using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BF9 RID: 27641
	public static class IOpenConfirmBoxWithReturnVerify
	{
		// Token: 0x06030969 RID: 199017 RVA: 0x006986B0 File Offset: 0x006968B0
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

		// Token: 0x02007DCE RID: 32206
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013972 RID: 80242
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
