using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D81 RID: 15745
	public static class ICheckTrapDefenseEventConditionVerify
	{
		// Token: 0x06015CD6 RID: 89302 RVA: 0x003248E4 File Offset: 0x00322AE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckTrapDefenseEventConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTrapDefenseEventConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ICheckTrapDefenseEventConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckTrapDefenseEventConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TCheckTrapDefenseEventVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078BF RID: 30911
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401313A RID: 78138
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401313B RID: 78139
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
