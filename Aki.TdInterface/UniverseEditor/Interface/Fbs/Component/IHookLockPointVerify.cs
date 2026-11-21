using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005950 RID: 22864
	public static class IHookLockPointVerify
	{
		// Token: 0x060253FE RID: 152574 RVA: 0x0051D17C File Offset: 0x0051B37C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHookLockPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHookLockPointVerify.<>O.<0>__Verify = new VerifyTableAction(ISphereTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					short offsetId2 = 18;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IHookLockPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IHookLockPointVerify.<>O.<1>__Verify = new VerifyTableAction(ICameraGazeVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 20;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IHookLockPointVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IHookLockPointVerify.<>O.<2>__Verify = new VerifyTableAction(IGazeNextPointAfterInteractVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 24, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 4UL, 4UL, false))
						{
							short offsetId4 = 30;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IHookLockPointVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IHookLockPointVerify.<>O.<3>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 38, 1UL, 1UL, false))
							{
								short typeIdVOffset = 38;
								short valueVOffset = 40;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = IHookLockPointVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IHookLockPointVerify.<>O.<4>__Verify = new VerifyUnionAction(THookLockScreenDetectTypeVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false) && verifier.VerifyField(tablePos, 42, 1UL, 1UL, false))
								{
									short typeIdVOffset2 = 42;
									short valueVOffset2 = 44;
									VerifyUnionAction verifyAction6;
									if ((verifyAction6 = IHookLockPointVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IHookLockPointVerify.<>O.<5>__Verify = new VerifyUnionAction(THookInteractConfigVerify.Verify));
									}
									if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction6, false))
									{
										short offsetId5 = 46;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IHookLockPointVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IHookLockPointVerify.<>O.<6>__Verify = new VerifyTableAction(IMechHookInteractConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId5, verifyAction7, false))
										{
											short offsetId6 = 48;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IHookLockPointVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IHookLockPointVerify.<>O.<7>__Verify = new VerifyTableAction(IMotorHookConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId6, verifyAction8, false))
											{
												short offsetId7 = 50;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IHookLockPointVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (IHookLockPointVerify.<>O.<8>__Verify = new VerifyTableAction(IHookGravityConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false) && verifier.VerifyField(tablePos, 52, 1UL, 1UL, false))
												{
													short offsetId8 = 54;
													VerifyTableAction verifyAction10;
													if ((verifyAction10 = IHookLockPointVerify.<>O.<9>__Verify) == null)
													{
														verifyAction10 = (IHookLockPointVerify.<>O.<9>__Verify = new VerifyTableAction(IHookPerformanceConfigVerify.Verify));
													}
													if (verifier.VerifyTable(tablePos, offsetId8, verifyAction10, false) && verifier.VerifyField(tablePos, 56, 2UL, 2UL, false))
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
			}
			return false;
		}

		// Token: 0x020083BD RID: 33725
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401463C RID: 83516
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401463D RID: 83517
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401463E RID: 83518
			public static VerifyTableAction <2>__Verify;

			// Token: 0x0401463F RID: 83519
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04014640 RID: 83520
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x04014641 RID: 83521
			public static VerifyUnionAction <5>__Verify;

			// Token: 0x04014642 RID: 83522
			public static VerifyTableAction <6>__Verify;

			// Token: 0x04014643 RID: 83523
			public static VerifyTableAction <7>__Verify;

			// Token: 0x04014644 RID: 83524
			public static VerifyTableAction <8>__Verify;

			// Token: 0x04014645 RID: 83525
			public static VerifyTableAction <9>__Verify;
		}
	}
}
