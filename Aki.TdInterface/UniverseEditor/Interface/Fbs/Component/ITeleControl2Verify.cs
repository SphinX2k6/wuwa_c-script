using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006049 RID: 24649
	public static class ITeleControl2Verify
	{
		// Token: 0x060299F9 RID: 170489 RVA: 0x005AEDC4 File Offset: 0x005ACFC4
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

		// Token: 0x020084C3 RID: 33987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147F8 RID: 83960
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147F9 RID: 83961
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040147FA RID: 83962
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040147FB RID: 83963
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040147FC RID: 83964
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040147FD RID: 83965
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040147FE RID: 83966
			public static VerifyUnionAction <6>__Verify;
		}
	}
}
