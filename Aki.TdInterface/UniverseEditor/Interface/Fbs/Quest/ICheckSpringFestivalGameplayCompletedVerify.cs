using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D66 RID: 15718
	public static class ICheckSpringFestivalGameplayCompletedVerify
	{
		// Token: 0x06015C04 RID: 89092 RVA: 0x003230DC File Offset: 0x003212DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckSpringFestivalGameplayCompletedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckSpringFestivalGameplayCompletedVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICheckSpringFestivalGameplayCompletedVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckSpringFestivalGameplayCompletedVerify.<>O.<1>__Verify = new VerifyUnionAction(TCheckSpringFestivalGameplayTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078BD RID: 30909
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013137 RID: 78135
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013138 RID: 78136
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
