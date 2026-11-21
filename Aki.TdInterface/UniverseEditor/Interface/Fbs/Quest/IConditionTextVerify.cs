using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D1 RID: 16849
	public static class IConditionTextVerify
	{
		// Token: 0x060175F5 RID: 95733 RVA: 0x00357670 File Offset: 0x00355870
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionTextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionTextVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IConditionTextVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionTextVerify.<>O.<1>__Verify = new VerifyUnionAction(TQuestScheduleVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IConditionTextVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IConditionTextVerify.<>O.<2>__Verify = new VerifyTableAction(IProgressBarVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008110 RID: 33040
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141C6 RID: 82374
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141C7 RID: 82375
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x040141C8 RID: 82376
			public static VerifyTableAction <2>__Verify;
		}
	}
}
