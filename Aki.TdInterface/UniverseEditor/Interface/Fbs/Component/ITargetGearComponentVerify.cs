using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A27 RID: 23079
	public static class ITargetGearComponentVerify
	{
		// Token: 0x06027379 RID: 160633 RVA: 0x005653E0 File Offset: 0x005635E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITargetGearComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITargetGearComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITargetGearComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITargetGearComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false))
					{
						short offsetId2 = 12;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ITargetGearComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (ITargetGearComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IHitTimeScaleRatioVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ITargetGearComponentVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (ITargetGearComponentVerify.<>O.<2>__Verify = new VerifyTableAction(IAimPartVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction4, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
							{
								short typeIdVOffset2 = 24;
								short valueVOffset2 = 26;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = ITargetGearComponentVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (ITargetGearComponentVerify.<>O.<3>__Verify = new VerifyUnionAction(THitLogicTypeVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction5, false))
								{
									short offsetId4 = 28;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ITargetGearComponentVerify.<>O.<4>__Verify) == null)
									{
										verifyAction6 = (ITargetGearComponentVerify.<>O.<4>__Verify = new VerifyTableAction(ISplineMoveVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId4, verifyAction6, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
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

		// Token: 0x02007C51 RID: 31825
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401374B RID: 79691
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401374C RID: 79692
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401374D RID: 79693
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401374E RID: 79694
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x0401374F RID: 79695
			public static VerifyTableAction <4>__Verify;
		}
	}
}
