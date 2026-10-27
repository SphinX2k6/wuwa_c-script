using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005688 RID: 22152
	public static class INpcUiInteractOnSunSpiritVerify
	{
		// Token: 0x06024F38 RID: 151352 RVA: 0x0051A39C File Offset: 0x0051859C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 18, false))
						{
							short offsetId4 = 20;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false))
							{
								short typeIdVOffset = 22;
								short valueVOffset = 24;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = INpcUiInteractOnSunSpiritVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (INpcUiInteractOnSunSpiritVerify.<>O.<1>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false))
								{
									short offsetId5 = 26;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify) == null)
									{
										verifyAction6 = (INpcUiInteractOnSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
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

		// Token: 0x02007BBE RID: 31678
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401366C RID: 79468
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401366D RID: 79469
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
