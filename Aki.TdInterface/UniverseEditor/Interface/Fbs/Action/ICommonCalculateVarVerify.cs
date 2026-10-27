using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006479 RID: 25721
	public static class ICommonCalculateVarVerify
	{
		// Token: 0x0602C8FF RID: 182527 RVA: 0x0061E738 File Offset: 0x0061C938
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonCalculateVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonCalculateVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICommonCalculateVarVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ICommonCalculateVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 14;
						short valueVOffset3 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = ICommonCalculateVarVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ICommonCalculateVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
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

		// Token: 0x02007D30 RID: 32048
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401389F RID: 80031
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
