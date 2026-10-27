using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041EF RID: 16879
	public static class ITrackCustomBoardVerify
	{
		// Token: 0x06018E63 RID: 101987 RVA: 0x0039528C File Offset: 0x0039348C
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
											return verifier.VerifyTableEnd(tablePos);
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

		// Token: 0x0200796E RID: 31086
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132D3 RID: 78547
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040132D4 RID: 78548
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040132D5 RID: 78549
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040132D6 RID: 78550
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040132D7 RID: 78551
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040132D8 RID: 78552
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040132D9 RID: 78553
			public static VerifyTableAction <6>__Verify;
		}
	}
}
