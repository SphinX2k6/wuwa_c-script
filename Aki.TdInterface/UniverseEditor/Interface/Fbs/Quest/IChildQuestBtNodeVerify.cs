using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D8A RID: 15754
	public static class IChildQuestBtNodeVerify
	{
		// Token: 0x06015DF1 RID: 89585 RVA: 0x003288C4 File Offset: 0x00326AC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildQuestBtNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildQuestBtNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IFixProcessorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					short offsetId2 = 20;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IChildQuestBtNodeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IChildQuestBtNodeVerify.<>O.<1>__Verify = new VerifyTableAction(IItemGetUiConfigSpecialQuestVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
					{
						short offsetId3 = 34;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IChildQuestBtNodeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IChildQuestBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 36;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IChildQuestBtNodeVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IChildQuestBtNodeVerify.<>O.<2>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 38;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IChildQuestBtNodeVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IChildQuestBtNodeVerify.<>O.<3>__Verify = new VerifyTableAction(ITrackTargetVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false))
								{
									short typeIdVOffset = 40;
									short valueVOffset = 42;
									VerifyUnionAction verifyAction6;
									if ((verifyAction6 = IChildQuestBtNodeVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (IChildQuestBtNodeVerify.<>O.<4>__Verify = new VerifyUnionAction(TChildQuestConditionVerify.Verify));
									}
									if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction6, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 46, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 48, 1UL, 1UL, false))
									{
										short typeIdVOffset2 = 48;
										short valueVOffset2 = 50;
										VerifyUnionAction verifyAction7;
										if ((verifyAction7 = IChildQuestBtNodeVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (IChildQuestBtNodeVerify.<>O.<5>__Verify = new VerifyUnionAction(TSaveConfigVerify.Verify));
										}
										if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction7, false) && verifier.VerifyField(tablePos, 52, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 54, 4UL, 4UL, false))
										{
											short offsetId6 = 56;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IChildQuestBtNodeVerify.<>O.<6>__Verify) == null)
											{
												verifyAction8 = (IChildQuestBtNodeVerify.<>O.<6>__Verify = new VerifyTableAction(IStuckCheckConditionVerify.Verify));
											}
											if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction8, false))
											{
												short offsetId7 = 58;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IChildQuestBtNodeVerify.<>O.<7>__Verify) == null)
												{
													verifyAction9 = (IChildQuestBtNodeVerify.<>O.<7>__Verify = new VerifyTableAction(ITrackAreaTextVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false))
												{
													short offsetId8 = 60;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IChildQuestBtNodeVerify.<>O.<8>__Verify) == null)
													{
														verifyAction10 = (IChildQuestBtNodeVerify.<>O.<8>__Verify = new VerifyTableAction(ITrackCustomBoardVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId8, verifyAction10, false) && verifier.VerifyField(tablePos, 62, 2UL, 2UL, false))
													{
														return verifier.VerifyTableEnd(tablePos);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020078C1 RID: 30913
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401313D RID: 78141
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401313E RID: 78142
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401313F RID: 78143
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013140 RID: 78144
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013141 RID: 78145
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x04013142 RID: 78146
			public static VerifyUnionAction <5>__Verify;

			// Token: 0x04013143 RID: 78147
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013144 RID: 78148
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013145 RID: 78149
			public static VerifyTableAction <8>__Verify;
		}
	}
}
