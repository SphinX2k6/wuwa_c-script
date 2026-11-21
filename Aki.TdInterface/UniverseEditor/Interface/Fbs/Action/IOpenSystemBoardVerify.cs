using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200739F RID: 29599
	public static class IOpenSystemBoardVerify
	{
		// Token: 0x06033C22 RID: 212002 RVA: 0x006FB2BC File Offset: 0x006F94BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyString(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOpenSystemBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSystemBoardVerify.<>O.<0>__Verify = new VerifyTableAction(IPhotographConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IOpenSystemBoardVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOpenSystemBoardVerify.<>O.<1>__Verify = new VerifyTableAction(IInformationViewConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 28, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
					{
						short offsetId3 = 34;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IOpenSystemBoardVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IOpenSystemBoardVerify.<>O.<2>__Verify = new VerifyTableAction(ITransitionPopupConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 36, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 38, false) && verifier.VerifyField(tablePos, 40, 1UL, 1UL, false))
						{
							short typeIdVOffset = 40;
							short valueVOffset = 42;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = IOpenSystemBoardVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IOpenSystemBoardVerify.<>O.<3>__Verify = new VerifyUnionAction(TInfrActivityBuildStageTypeVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction4, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 46, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 48, 4UL, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 52, 4UL, 4UL, false))
							{
								short offsetId4 = 54;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IOpenSystemBoardVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IOpenSystemBoardVerify.<>O.<4>__Verify = new VerifyTableAction(IPictureCaptionConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false) && verifier.VerifyField(tablePos, 56, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 58, 1UL, 1UL, false))
								{
									short typeIdVOffset2 = 58;
									short valueVOffset2 = 60;
									VerifyUnionAction verifyAction6;
									if ((verifyAction6 = IOpenSystemBoardVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IOpenSystemBoardVerify.<>O.<5>__Verify = new VerifyUnionAction(TVillageInfrBuildTypeVerify.Verify));
									}
									if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction6, false) && verifier.VerifyString(tablePos, 62, false))
									{
										short offsetId5 = 64;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IOpenSystemBoardVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IOpenSystemBoardVerify.<>O.<6>__Verify = new VerifyTableAction(IQuestBranchConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId5, verifyAction7, false))
										{
											short offsetId6 = 66;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IOpenSystemBoardVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IOpenSystemBoardVerify.<>O.<7>__Verify = new VerifyTableAction(IWriteLetterConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId6, verifyAction8, false) && verifier.VerifyField(tablePos, 68, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 70, false))
											{
												short offsetId7 = 72;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IOpenSystemBoardVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (IOpenSystemBoardVerify.<>O.<8>__Verify = new VerifyTableAction(IDeliverItemProbeCollectiblesConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false) && verifier.VerifyField(tablePos, 74, 2UL, 2UL, false))
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

		// Token: 0x02008667 RID: 34407
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A47 RID: 84551
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A48 RID: 84552
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014A49 RID: 84553
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014A4A RID: 84554
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x04014A4B RID: 84555
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04014A4C RID: 84556
			public static VerifyUnionAction <5>__Verify;

			// Token: 0x04014A4D RID: 84557
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04014A4E RID: 84558
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04014A4F RID: 84559
			public static VerifyTableAction <8>__Verify;
		}
	}
}
