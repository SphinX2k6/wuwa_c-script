using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200500C RID: 20492
	public static class ICheckSceneItemDirectionConditionVerify
	{
		// Token: 0x0601FFCA RID: 131018 RVA: 0x004707A4 File Offset: 0x0046E9A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckSceneItemDirectionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckSceneItemDirectionConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckSceneItemDirectionConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckSceneItemDirectionConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200829B RID: 33435
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401447E RID: 83070
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401447F RID: 83071
			public static VerifyTableAction <1>__Verify;
		}
	}
}
