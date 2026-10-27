using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004276 RID: 17014
	public static class IVisionSystemQuestConditionVerify
	{
		// Token: 0x060192F3 RID: 103155 RVA: 0x0039E6C4 File Offset: 0x0039C8C4
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

		// Token: 0x0200797D RID: 31101
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132F7 RID: 78583
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132F8 RID: 78584
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
