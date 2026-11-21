using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004564 RID: 17764
	public static class IShowUiConditionVerify
	{
		// Token: 0x06019D70 RID: 105840 RVA: 0x003AFE0C File Offset: 0x003AE00C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowUiConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowUiConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IShowUiConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IShowUiConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TShowUiVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200819B RID: 33179
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014301 RID: 82689
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014302 RID: 82690
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
