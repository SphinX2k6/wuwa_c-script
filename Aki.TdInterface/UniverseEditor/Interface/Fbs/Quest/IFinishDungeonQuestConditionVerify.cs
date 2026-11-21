using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004270 RID: 17008
	public static class IFinishDungeonQuestConditionVerify
	{
		// Token: 0x06017B65 RID: 97125 RVA: 0x00361DB8 File Offset: 0x0035FFB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFinishDungeonQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFinishDungeonQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IFinishDungeonQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFinishDungeonQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TDungeonConditionTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008123 RID: 33059
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141E3 RID: 82403
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040141E4 RID: 82404
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
