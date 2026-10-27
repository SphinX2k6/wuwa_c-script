using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705A RID: 28762
	public static class ISetPlotModeVerify
	{
		// Token: 0x06032EE3 RID: 208611 RVA: 0x006DEFA0 File Offset: 0x006DD1A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
			{
				short offsetId = 20;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetPlotModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetPlotModeVerify.<>O.<0>__Verify = new VerifyTableAction(IFadeInScreenVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
				{
					short typeIdVOffset = 24;
					short valueVOffset = 26;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISetPlotModeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetPlotModeVerify.<>O.<1>__Verify = new VerifyUnionAction(TPromptStyleVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
					{
						short typeIdVOffset2 = 28;
						short valueVOffset2 = 30;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = ISetPlotModeVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISetPlotModeVerify.<>O.<2>__Verify = new VerifyUnionAction(TSubtitleStyleVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction3, false))
						{
							short offsetId2 = 32;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISetPlotModeVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ISetPlotModeVerify.<>O.<3>__Verify = new VerifyTableAction(IPhoneMessageConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId2, verifyAction4, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
							{
								short offsetId3 = 38;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ISetPlotModeVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ISetPlotModeVerify.<>O.<4>__Verify = new VerifyTableAction(IPlotFilmModeConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId3, verifyAction5, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false))
								{
									short offsetId4 = 44;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ISetPlotModeVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ISetPlotModeVerify.<>O.<5>__Verify = new VerifyTableAction(IEntityControlConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId4, verifyAction6, false))
									{
										short offsetId5 = 46;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ISetPlotModeVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ISetPlotModeVerify.<>O.<6>__Verify = new VerifyTableAction(IVisualNovelConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId5, verifyAction7, false))
										{
											short offsetId6 = 48;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ISetPlotModeVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (ISetPlotModeVerify.<>O.<7>__Verify = new VerifyTableAction(IPlotModeUiStyleLevelDVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId6, verifyAction8, false))
											{
												short offsetId7 = 50;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = ISetPlotModeVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (ISetPlotModeVerify.<>O.<8>__Verify = new VerifyTableAction(IPlotAudioConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false) && verifier.VerifyField(tablePos, 52, 2UL, 2UL, false))
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
			return false;
		}

		// Token: 0x02007E4C RID: 32332
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A19 RID: 80409
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A1A RID: 80410
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013A1B RID: 80411
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x04013A1C RID: 80412
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013A1D RID: 80413
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013A1E RID: 80414
			public static VerifyTableAction <5>__Verify;

			// Token: 0x04013A1F RID: 80415
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04013A20 RID: 80416
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04013A21 RID: 80417
			public static VerifyTableAction <8>__Verify;
		}
	}
}
