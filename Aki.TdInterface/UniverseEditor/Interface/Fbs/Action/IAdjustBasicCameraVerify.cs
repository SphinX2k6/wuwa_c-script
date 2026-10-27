using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006145 RID: 24901
	public static class IAdjustBasicCameraVerify
	{
		// Token: 0x0602AAA8 RID: 174760 RVA: 0x005E09E8 File Offset: 0x005DEBE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdjustBasicCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdjustBasicCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdjustBasicCameraVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdjustBasicCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false))
					{
						short offsetId3 = 22;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IAdjustBasicCameraVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IAdjustBasicCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 24;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IAdjustBasicCameraVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IAdjustBasicCameraVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IAdjustBasicCameraVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IAdjustBasicCameraVerify.<>O.<2>__Verify = new VerifyUnionAction(TGravityDirectionVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 44, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 46, false) && verifier.VerifyField(tablePos, 48, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 50, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 54, 4UL, 4UL, false))
								{
									short offsetId5 = 56;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IAdjustBasicCameraVerify.<>O.<3>__Verify) == null)
									{
										verifyAction6 = (IAdjustBasicCameraVerify.<>O.<3>__Verify = new VerifyTableAction(ISpringArmSoftZoneConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
									{
										short offsetId6 = 58;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IAdjustBasicCameraVerify.<>O.<4>__Verify) == null)
										{
											verifyAction7 = (IAdjustBasicCameraVerify.<>O.<4>__Verify = new VerifyTableAction(ISpringArmFixConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 60, 1UL, 1UL, false))
										{
											short offsetId7 = 62;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IAdjustBasicCameraVerify.<>O.<5>__Verify) == null)
											{
												verifyAction8 = (IAdjustBasicCameraVerify.<>O.<5>__Verify = new VerifyTableAction(ICameraLockConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId7, verifyAction8, false) && verifier.VerifyField(tablePos, 64, 2UL, 2UL, false))
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

		// Token: 0x02007CE2 RID: 31970
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401381E RID: 79902
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401381F RID: 79903
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013820 RID: 79904
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x04013821 RID: 79905
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013822 RID: 79906
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013823 RID: 79907
			public static VerifyTableAction <5>__Verify;
		}
	}
}
