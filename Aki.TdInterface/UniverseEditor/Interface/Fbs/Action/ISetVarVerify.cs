using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A5 RID: 28837
	public static class ISetVarVerify
	{
		// Token: 0x0603310E RID: 209166 RVA: 0x006E34CC File Offset: 0x006E16CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISetVarVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISetVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E58 RID: 32344
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A2F RID: 80431
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
