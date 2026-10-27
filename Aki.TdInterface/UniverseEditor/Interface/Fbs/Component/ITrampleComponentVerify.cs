using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ACB RID: 23243
	public static class ITrampleComponentVerify
	{
		// Token: 0x06027A40 RID: 162368 RVA: 0x00573F08 File Offset: 0x00572108
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrampleComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrampleComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITrampleComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrampleComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ITrampleRayDetectionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITrampleComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITrampleComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IEntityMatchVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITrampleComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITrampleComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IEnterLeaveRadiusVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
							{
								short offsetId5 = 28;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITrampleComponentVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITrampleComponentVerify.<>O.<4>__Verify = new VerifyTableAction(ICountDownTextTipVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 30;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITrampleComponentVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITrampleComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction6, false))
									{
										short offsetId7 = 32;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = ITrampleComponentVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (ITrampleComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
										}
										if (verifier.VerifyVectorOfTables(tablePos, offsetId7, verifyAction7, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false))
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

		// Token: 0x02007C69 RID: 31849
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401377F RID: 79743
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013780 RID: 79744
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013781 RID: 79745
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013782 RID: 79746
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013783 RID: 79747
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013784 RID: 79748
			public static VerifyTableAction <5>__Verify;
		}
	}
}
