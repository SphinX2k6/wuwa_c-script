using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B29 RID: 27433
	public static class IConditionVerify
	{
		// Token: 0x0602F333 RID: 193331 RVA: 0x006721AC File Offset: 0x006703AC
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

		// Token: 0x020085A8 RID: 34216
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401494D RID: 84301
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
