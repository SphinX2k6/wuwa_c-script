using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200417D RID: 16765
	public static class ICheckSpringFestivalGameplayCompletedVerify
	{
		// Token: 0x0601713C RID: 94524 RVA: 0x0034A354 File Offset: 0x00348554
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

		// Token: 0x02008101 RID: 33025
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014193 RID: 82323
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014194 RID: 82324
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
