using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043AE RID: 17326
	public static class IParallaxAlignQuestConditionVerify
	{
		// Token: 0x06018855 RID: 100437 RVA: 0x0037E520 File Offset: 0x0037C720
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IParallaxAlignQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IParallaxAlignQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IParallaxAlignQuestConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IParallaxAlignQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IParallaxAlignQuestConditionVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IParallaxAlignQuestConditionVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IParallaxAlignQuestConditionVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IParallaxAlignQuestConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IParallaxPointPairVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false))
							{
								short offsetId5 = 24;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IParallaxAlignQuestConditionVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IParallaxAlignQuestConditionVerify.<>O.<3>__Verify = new VerifyTableAction(IColorVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008158 RID: 33112
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014248 RID: 82504
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014249 RID: 82505
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401424A RID: 82506
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401424B RID: 82507
			public static VerifyTableAction <3>__Verify;
		}
	}
}
