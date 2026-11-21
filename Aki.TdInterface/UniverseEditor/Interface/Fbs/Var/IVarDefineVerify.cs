using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F03 RID: 16131
	public static class IVarDefineVerify
	{
		// Token: 0x06015E46 RID: 89670 RVA: 0x00326000 File Offset: 0x00324200
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVarDefineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVarDefineVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 18;
					short valueVOffset2 = 20;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVarDefineVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVarDefineVerify.<>O.<1>__Verify = new VerifyUnionAction(TVarValidateConfigVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080C6 RID: 32966
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014146 RID: 82246
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014147 RID: 82247
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
