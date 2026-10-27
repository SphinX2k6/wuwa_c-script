using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200626E RID: 25198
	public static class ICalculateVarVerify
	{
		// Token: 0x0602B7CE RID: 178126 RVA: 0x005FCD4C File Offset: 0x005FAF4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICalculateVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICalculateVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICalculateVarVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICalculateVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 14;
						short valueVOffset3 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = ICalculateVarVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ICalculateVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007CFD RID: 31997
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401385C RID: 79964
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
