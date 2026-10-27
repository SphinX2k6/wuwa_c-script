using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064BE RID: 25790
	public static class IConditionVerify
	{
		// Token: 0x0602CBAF RID: 183215 RVA: 0x00626084 File Offset: 0x00624284
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 8;
					short valueVOffset2 = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IConditionVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyString(tablePos, 12, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D33 RID: 32051
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A2 RID: 80034
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
