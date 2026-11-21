using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004648 RID: 17992
	public static class ITrackCustomBoardVerify
	{
		// Token: 0x0601A5BD RID: 107965 RVA: 0x003C07C4 File Offset: 0x003BE9C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrackCustomBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrackCustomBoardVerify.<>O.<0>__Verify = new VerifyTableAction(IPhoneMessageBoardConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrackCustomBoardVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrackCustomBoardVerify.<>O.<1>__Verify = new VerifyTableAction(ITrackQuestBranchBoardConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrackCustomBoardVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrackCustomBoardVerify.<>O.<2>__Verify = new VerifyTableAction(ISheriffAnomalyProgressBoardConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 10;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITrackCustomBoardVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITrackCustomBoardVerify.<>O.<3>__Verify = new VerifyTableAction(ISheriffReasoningBoardConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 12;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITrackCustomBoardVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITrackCustomBoardVerify.<>O.<4>__Verify = new VerifyTableAction(ISheriffMainBoardConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 14;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITrackCustomBoardVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITrackCustomBoardVerify.<>O.<5>__Verify = new VerifyTableAction(ISheriffClueDetailBoardConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 16;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITrackCustomBoardVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ITrackCustomBoardVerify.<>O.<6>__Verify = new VerifyTableAction(ITrackReturnDungeonVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId7, verifyAction7, false))
										{
											short offsetId8 = 18;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = ITrackCustomBoardVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (ITrackCustomBoardVerify.<>O.<7>__Verify = new VerifyTableAction(ITrackHandBookBoardConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId8, verifyAction8, false))
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
			return false;
		}

		// Token: 0x020081B7 RID: 33207
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014339 RID: 82745
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401433A RID: 82746
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401433B RID: 82747
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401433C RID: 82748
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401433D RID: 82749
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401433E RID: 82750
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401433F RID: 82751
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04014340 RID: 82752
			public static VerifyTableAction <7>__Verify;
		}
	}
}
