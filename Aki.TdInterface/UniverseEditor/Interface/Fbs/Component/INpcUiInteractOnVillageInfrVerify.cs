using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568B RID: 22155
	public static class INpcUiInteractOnVillageInfrVerify
	{
		// Token: 0x06024F6E RID: 151406 RVA: 0x0051AE80 File Offset: 0x00519080
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcUiInteractOnVillageInfrVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnVillageInfrVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnVillageInfrVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnVillageInfrVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 14;
						short valueVOffset3 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnVillageInfrVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnVillageInfrVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction3, false))
						{
							short offsetId = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnVillageInfrVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnVillageInfrVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId, verifyAction4, false))
							{
								short offsetId2 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = INpcUiInteractOnVillageInfrVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (INpcUiInteractOnVillageInfrVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId2, verifyAction5, false))
								{
									short offsetId3 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = INpcUiInteractOnVillageInfrVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (INpcUiInteractOnVillageInfrVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId3, verifyAction6, false))
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

		// Token: 0x02007BBF RID: 31679
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401366E RID: 79470
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x0401366F RID: 79471
			public static VerifyTableAction <1>__Verify;
		}
	}
}
