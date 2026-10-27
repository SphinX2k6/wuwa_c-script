using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3C RID: 23100
	public static class ITeleControl2Verify
	{
		// Token: 0x06027481 RID: 160897 RVA: 0x00567DB8 File Offset: 0x00565FB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleControl2Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleControl2Verify.<>O.<0>__Verify = new VerifyTableAction(ITeleControlBaseCfgVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITeleControl2Verify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITeleControl2Verify.<>O.<1>__Verify = new VerifyTableAction(ISearchTargetCfgVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITeleControl2Verify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ITeleControl2Verify.<>O.<2>__Verify = new VerifyTableAction(IBulletCfgVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITeleControl2Verify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (ITeleControl2Verify.<>O.<3>__Verify = new VerifyTableAction(IDestroyCfgVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 14;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ITeleControl2Verify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (ITeleControl2Verify.<>O.<4>__Verify = new VerifyTableAction(IHoldCfgVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 16;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITeleControl2Verify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (ITeleControl2Verify.<>O.<5>__Verify = new VerifyTableAction(IThrowCfgVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 20, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
									{
										short typeIdVOffset = 24;
										short valueVOffset = 26;
										VerifyUnionAction verifyAction7;
										if ((verifyAction7 = ITeleControl2Verify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (ITeleControl2Verify.<>O.<6>__Verify = new VerifyUnionAction(TTeleCtrlTriggerConfigVerify.Verify));
										}
										if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction7, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
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

		// Token: 0x02007C54 RID: 31828
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013754 RID: 79700
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013755 RID: 79701
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013756 RID: 79702
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013757 RID: 79703
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013758 RID: 79704
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013759 RID: 79705
			public static VerifyTableAction <5>__Verify;

			// Token: 0x0401375A RID: 79706
			public static VerifyUnionAction <6>__Verify;
		}
	}
}
