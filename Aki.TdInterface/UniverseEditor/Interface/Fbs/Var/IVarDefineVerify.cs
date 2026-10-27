using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B01 RID: 15105
	public static class IVarDefineVerify
	{
		// Token: 0x0601499C RID: 84380 RVA: 0x002FFD70 File Offset: 0x002FDF70
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

		// Token: 0x02007883 RID: 30851
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130EB RID: 78059
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040130EC RID: 78060
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
