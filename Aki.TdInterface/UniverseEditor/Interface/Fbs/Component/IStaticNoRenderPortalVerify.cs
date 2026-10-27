using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C7 RID: 22983
	public static class IStaticNoRenderPortalVerify
	{
		// Token: 0x06026F8D RID: 159629 RVA: 0x0055CCA0 File Offset: 0x0055AEA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStaticNoRenderPortalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStaticNoRenderPortalVerify.<>O.<0>__Verify = new VerifyTableAction(ITeleportSceneEffectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset = 12;
					short valueVOffset = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IStaticNoRenderPortalVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStaticNoRenderPortalVerify.<>O.<1>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IStaticNoRenderPortalVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IStaticNoRenderPortalVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							short offsetId3 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IStaticNoRenderPortalVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IStaticNoRenderPortalVerify.<>O.<3>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								short offsetId4 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IStaticNoRenderPortalVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IStaticNoRenderPortalVerify.<>O.<4>__Verify = new VerifyTableAction(IGravityFlipTeleportConfigVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 26, 4UL, false))
								{
									short offsetId5 = 28;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IStaticNoRenderPortalVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IStaticNoRenderPortalVerify.<>O.<5>__Verify = new VerifyTableAction(IAfterTeleportConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyField(tablePos, 30, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false))
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

		// Token: 0x02007C40 RID: 31808
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013730 RID: 79664
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013731 RID: 79665
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013732 RID: 79666
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04013733 RID: 79667
			public static VerifyTableAction <3>__Verify;

			// Token: 0x04013734 RID: 79668
			public static VerifyTableAction <4>__Verify;

			// Token: 0x04013735 RID: 79669
			public static VerifyTableAction <5>__Verify;
		}
	}
}
