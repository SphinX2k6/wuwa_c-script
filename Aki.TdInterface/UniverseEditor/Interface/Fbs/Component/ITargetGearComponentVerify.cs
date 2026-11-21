using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006034 RID: 24628
	public static class ITargetGearComponentVerify
	{
		// Token: 0x060298F1 RID: 170225 RVA: 0x005AC3A4 File Offset: 0x005AA5A4
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

		// Token: 0x020084C0 RID: 33984
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147EF RID: 83951
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040147F0 RID: 83952
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040147F1 RID: 83953
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040147F2 RID: 83954
			public static VerifyUnionAction <3>__Verify;

			// Token: 0x040147F3 RID: 83955
			public static VerifyTableAction <4>__Verify;
		}
	}
}
