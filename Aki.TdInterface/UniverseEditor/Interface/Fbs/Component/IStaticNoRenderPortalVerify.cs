using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD4 RID: 24532
	public static class IStaticNoRenderPortalVerify
	{
		// Token: 0x06029505 RID: 169221 RVA: 0x005A3C3C File Offset: 0x005A1E3C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStaticNoRenderPortalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStaticNoRenderPortalVerify.<>O.<0>__Verify = new VerifyTableAction(ICubeMapBindingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IStaticNoRenderPortalVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IStaticNoRenderPortalVerify.<>O.<1>__Verify = new VerifyTableAction(ITeleportSceneEffectVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset = 14;
						short valueVOffset = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = IStaticNoRenderPortalVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IStaticNoRenderPortalVerify.<>O.<2>__Verify = new VerifyUnionAction(TTeleportTransitionOptionVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction3, false))
						{
							short offsetId3 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IStaticNoRenderPortalVerify.<>O.<3>__Verify) == null)
							{
								verifyAction4 = (IStaticNoRenderPortalVerify.<>O.<3>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId3, verifyAction4, false))
							{
								short offsetId4 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IStaticNoRenderPortalVerify.<>O.<4>__Verify) == null)
								{
									verifyAction5 = (IStaticNoRenderPortalVerify.<>O.<4>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false))
								{
									short offsetId5 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = IStaticNoRenderPortalVerify.<>O.<5>__Verify) == null)
									{
										verifyAction6 = (IStaticNoRenderPortalVerify.<>O.<5>__Verify = new VerifyTableAction(IGravityFlipTeleportConfigVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 28, 4UL, false))
									{
										short offsetId6 = 30;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = IStaticNoRenderPortalVerify.<>O.<6>__Verify) == null)
										{
											verifyAction7 = (IStaticNoRenderPortalVerify.<>O.<6>__Verify = new VerifyTableAction(IAfterTeleportConfigVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId6, verifyAction7, false) && verifier.VerifyField(tablePos, 32, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false))
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

		// Token: 0x020084AF RID: 33967
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147D3 RID: 83923
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147D4 RID: 83924
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040147D5 RID: 83925
			public static VerifyUnionAction <2>__Verify;

			// Token: 0x040147D6 RID: 83926
			public static VerifyTableAction <3>__Verify;

			// Token: 0x040147D7 RID: 83927
			public static VerifyTableAction <4>__Verify;

			// Token: 0x040147D8 RID: 83928
			public static VerifyTableAction <5>__Verify;

			// Token: 0x040147D9 RID: 83929
			public static VerifyTableAction <6>__Verify;
		}
	}
}
