using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044AD RID: 17581
	public static class IReachAreaQuestConditionVerify
	{
		// Token: 0x06019617 RID: 103959 RVA: 0x0039F668 File Offset: 0x0039D868
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReachAreaQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReachAreaQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IReachAreaQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IReachAreaQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 16, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 18, 1UL, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200818C RID: 33164
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142C4 RID: 82628
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040142C5 RID: 82629
			public static VerifyTableAction <1>__Verify;
		}
	}
}
