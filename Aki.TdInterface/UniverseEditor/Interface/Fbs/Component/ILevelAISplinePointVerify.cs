using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054DB RID: 21723
	public static class ILevelAISplinePointVerify
	{
		// Token: 0x06023D19 RID: 146713 RVA: 0x004F39EC File Offset: 0x004F1BEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelAISplinePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelAISplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILevelAISplinePointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ILevelAISplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ILevelAISplinePointVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ILevelAISplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ILevelAISplinePointVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (ILevelAISplinePointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false))
							{
								short offsetId5 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ILevelAISplinePointVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (ILevelAISplinePointVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
								{
									short offsetId6 = 24;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ILevelAISplinePointVerify.<>O.<2>__Verify) == null)
									{
										verifyAction6 = (ILevelAISplinePointVerify.<>O.<2>__Verify = new VerifyTableAction(ILevelAiPointOffsetConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
									{
										return verifier.VerifyTableEnd(tablePos);
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B7E RID: 31614
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135FB RID: 79355
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135FC RID: 79356
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040135FD RID: 79357
			public static VerifyTableAction <2>__Verify;
		}
	}
}
