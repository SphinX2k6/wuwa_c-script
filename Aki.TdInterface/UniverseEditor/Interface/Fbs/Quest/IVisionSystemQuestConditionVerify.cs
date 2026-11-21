using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D2 RID: 18130
	public static class IVisionSystemQuestConditionVerify
	{
		// Token: 0x0601AA5F RID: 109151 RVA: 0x003C9D9C File Offset: 0x003C7F9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisionSystemQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisionSystemQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IVisionSystemQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IVisionSystemQuestConditionVerify.<>O.<1>__Verify = new VerifyUnionAction(TVisionSystemQuestVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020081C6 RID: 33222
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401435E RID: 82782
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401435F RID: 82783
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
