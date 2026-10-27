using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E09 RID: 28169
	public static class IRandomVarVerify
	{
		// Token: 0x06031C67 RID: 203879 RVA: 0x006BD4D0 File Offset: 0x006BB6D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRandomVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRandomVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IRandomVarVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IRandomVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 12;
						short valueVOffset3 = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IRandomVarVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IRandomVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
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

		// Token: 0x02007E09 RID: 32265
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C4 RID: 80324
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
