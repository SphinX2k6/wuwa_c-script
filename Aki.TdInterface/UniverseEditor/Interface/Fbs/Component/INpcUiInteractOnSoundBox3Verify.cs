using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005682 RID: 22146
	public static class INpcUiInteractOnSoundBox3Verify
	{
		// Token: 0x06024EAC RID: 151212 RVA: 0x00518BAC File Offset: 0x00516DAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 18, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								short typeIdVOffset = 22;
								short valueVOffset = 24;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = INpcUiInteractOnSoundBox3Verify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (INpcUiInteractOnSoundBox3Verify.<>O.<1>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false))
								{
									short offsetId5 = 26;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify) == null)
									{
										verifyAction6 = (INpcUiInteractOnSoundBox3Verify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId5, verifyAction6, false))
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

		// Token: 0x02007BBC RID: 31676
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013668 RID: 79464
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013669 RID: 79465
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
