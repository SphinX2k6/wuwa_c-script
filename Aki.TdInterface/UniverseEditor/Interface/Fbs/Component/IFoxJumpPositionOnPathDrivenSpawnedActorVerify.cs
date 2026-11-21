using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005837 RID: 22583
	public static class IFoxJumpPositionOnPathDrivenSpawnedActorVerify
	{
		// Token: 0x0602490A RID: 149770 RVA: 0x00506188 File Offset: 0x00504388
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<1>__Verify = new VerifyTableAction(IFoxJumpShapeAndPointsParamsVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
						{
							short offsetId4 = 14;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<1>__Verify = new VerifyTableAction(IFoxJumpShapeAndPointsParamsVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 16;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IFoxJumpPositionOnPathDrivenSpawnedActorVerify.<>O.<2>__Verify = new VerifyTableAction(IBoxTriggerShapeVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
								{
									return verifier.VerifyTableEnd(tablePos);
								}
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008391 RID: 33681
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145F6 RID: 83446
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145F7 RID: 83447
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040145F8 RID: 83448
			public static VerifyTableAction <2>__Verify;
		}
	}
}
