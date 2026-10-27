using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F70 RID: 16240
	public static class IParallaxAlignQuestConditionVerify
	{
		// Token: 0x060171E5 RID: 94693 RVA: 0x00354E18 File Offset: 0x00353018
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
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IParallaxAlignQuestConditionVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IParallaxAlignQuestConditionVerify.<>O.<2>__Verify = new VerifyTableAction(IColorVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007912 RID: 30994
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E8 RID: 78312
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131E9 RID: 78313
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040131EA RID: 78314
			public static VerifyTableAction <2>__Verify;
		}
	}
}
