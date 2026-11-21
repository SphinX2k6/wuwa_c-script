using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Actor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EAC RID: 24236
	public static class ISceneActorRefComponentVerify
	{
		// Token: 0x060289A9 RID: 166313 RVA: 0x0058D1A0 File Offset: 0x0058B3A0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneActorRefComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneActorRefComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneActorRefGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneActorRefComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneActorRefComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISceneActorRefComponentVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISceneActorRefComponentVerify.<>O.<2>__Verify = new VerifyTableAction(ILiftFloorSeqMarkConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISceneActorRefComponentVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (ISceneActorRefComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
							}
							if (verifier.VerifyVectorOfTables(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 14;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ISceneActorRefComponentVerify.<>O.<3>__Verify) == null)
								{
									verifyAction5 = (ISceneActorRefComponentVerify.<>O.<3>__Verify = new VerifyTableAction(IRefactorActorRef2EntitiesVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false))
								{
									short offsetId6 = 16;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = ISceneActorRefComponentVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (ISceneActorRefComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActorRefVerify.Verify));
									}
									if (verifier.VerifyVectorOfTables(tablePos, offsetId6, verifyAction6, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
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

		// Token: 0x02008485 RID: 33925
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014793 RID: 83859
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014794 RID: 83860
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014795 RID: 83861
			public static VerifyTableAction <2>__Verify;

			// Token: 0x04014796 RID: 83862
			public static VerifyTableAction <3>__Verify;
		}
	}
}
