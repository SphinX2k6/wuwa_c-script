using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B25 RID: 19237
	public static class ICheckSceneItemDirectionConditionVerify
	{
		// Token: 0x0601E43F RID: 123967 RVA: 0x0043DFF8 File Offset: 0x0043C1F8
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

		// Token: 0x02007A49 RID: 31305
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401340E RID: 78862
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401340F RID: 78863
			public static VerifyTableAction <1>__Verify;
		}
	}
}
