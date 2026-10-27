using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AB RID: 21675
	public static class IJigsawFoundationVerify
	{
		// Token: 0x06023B07 RID: 146183 RVA: 0x004EF18C File Offset: 0x004ED38C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IJigsawFoundationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IJigsawFoundationVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IJigsawFoundationVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IJigsawFoundationVerify.<>O.<1>__Verify = new VerifyTableAction(IJigsawPieceMatchVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short typeIdVOffset = 12;
						short valueVOffset = 14;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IJigsawFoundationVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IJigsawFoundationVerify.<>O.<2>__Verify = new VerifyUnionAction(TJigsawCompleteConditionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false))
						{
							short offsetId3 = 16;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IJigsawFoundationVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IJigsawFoundationVerify.<>O.<3>__Verify = new VerifyTableAction(IJigsawCompletedConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								short offsetId4 = 18;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IJigsawFoundationVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IJigsawFoundationVerify.<>O.<4>__Verify = new VerifyTableAction(IJigsawConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false))
								{
									short offsetId5 = 20;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IJigsawFoundationVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IJigsawFoundationVerify.<>O.<5>__Verify = new VerifyTableAction(IJigsawItemMatchedConfigVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
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

		// Token: 0x02007B75 RID: 31605
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135E8 RID: 79336
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135E9 RID: 79337
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040135EA RID: 79338
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040135EB RID: 79339
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040135EC RID: 79340
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040135ED RID: 79341
			public static VerifyTableAction <5>__Verify;
		}
	}
}
