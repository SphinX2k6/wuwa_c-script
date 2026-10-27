using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053CA RID: 21450
	public static class IHookLockPointVerify
	{
		// Token: 0x06023346 RID: 144198 RVA: 0x004E017C File Offset: 0x004DE37C
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
											verifyAction7 = (IHookLockPointVerify.<>O.<6>__Verify = new VerifyTableAction(IMotorHookConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId5, verifyAction7, false))
										{
											short offsetId6 = 48;
											VerifyTableAction verifyAction8;
											if ((verifyAction8 = IHookLockPointVerify.<>O.<7>__Verify) == null)
											{
												verifyAction8 = (IHookLockPointVerify.<>O.<7>__Verify = new VerifyTableAction(IHookGravityConfigVerify.Verify));
											}
											if (verifier.VerifyTable(tablePos, offsetId6, verifyAction8, false) && verifier.VerifyField(tablePos, 50, 1UL, 1UL, false))
											{
												short offsetId7 = 52;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = IHookLockPointVerify.<>O.<8>__Verify) == null)
												{
													verifyAction9 = (IHookLockPointVerify.<>O.<8>__Verify = new VerifyTableAction(IHookPerformanceConfigVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId7, verifyAction9, false) && verifier.VerifyField(tablePos, 54, 2UL, 2UL, false))
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
			return false;
		}

		// Token: 0x02007B5E RID: 31582
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135B7 RID: 79287
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040135B8 RID: 79288
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040135B9 RID: 79289
			public static VerifyTableAction <2>__Verify;

			// Token: 0x040135BA RID: 79290
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040135BB RID: 79291
			public static VerifyUnionAction <4>__Verify;

			// Token: 0x040135BC RID: 79292
			public static VerifyUnionAction <5>__Verify;

			// Token: 0x040135BD RID: 79293
			public static VerifyTableAction <6>__Verify;

			// Token: 0x040135BE RID: 79294
			public static VerifyTableAction <7>__Verify;

			// Token: 0x040135BF RID: 79295
			public static VerifyTableAction <8>__Verify;
		}
	}
}
