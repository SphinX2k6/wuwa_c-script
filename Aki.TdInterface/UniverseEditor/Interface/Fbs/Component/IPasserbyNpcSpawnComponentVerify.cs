using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC8 RID: 23752
	public static class IPasserbyNpcSpawnComponentVerify
	{
		// Token: 0x060276BA RID: 161466 RVA: 0x005653C8 File Offset: 0x005635C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPasserbyNpcSpawnComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcSpawnComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TPasserbyNpcMoveVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IPasserbyNpcSpawnComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPasserbyNpcSpawnComponentVerify.<>O.<1>__Verify = new VerifyUnionAction(TPasserbyNpcSpawnVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false))
					{
						short offsetId = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPasserbyNpcSpawnComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IPasserbyNpcSpawnComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IPasserbyNpcTemplateSourceVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId, verifyAction3, false) && verifier.VerifyString(tablePos, 16, false))
						{
							short offsetId2 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPasserbyNpcSpawnComponentVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IPasserbyNpcSpawnComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IPasserbyNpcPerformanceVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId2, verifyAction4, false))
							{
								short offsetId3 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IPasserbyNpcSpawnComponentVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (IPasserbyNpcSpawnComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IPasserbyNpcPerformanceVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId3, verifyAction5, false))
								{
									short offsetId4 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IPasserbyNpcSpawnComponentVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (IPasserbyNpcSpawnComponentVerify.<>O.<4>__Verify = new VerifyTableAction(IPasserbyNpcDeviceGradeConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId4, verifyAction6, false))
									{
										short offsetId5 = 24;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IPasserbyNpcSpawnComponentVerify.<>O.<5>__Verify) == null)
										{
											verifyAction7 = (IPasserbyNpcSpawnComponentVerify.<>O.<5>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId5, verifyAction7, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
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

		// Token: 0x02008435 RID: 33845
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014717 RID: 83735
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014718 RID: 83736
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04014719 RID: 83737
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401471A RID: 83738
			public static VerifyTableAction <3>__Verify;

			// Token: 0x0401471B RID: 83739
			public static VerifyTableAction <4>__Verify;

			// Token: 0x0401471C RID: 83740
			public static VerifyTableAction <5>__Verify;
		}
	}
}
