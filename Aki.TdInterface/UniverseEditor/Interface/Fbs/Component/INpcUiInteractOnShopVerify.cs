using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567C RID: 22140
	public static class INpcUiInteractOnShopVerify
	{
		// Token: 0x06024E20 RID: 151072 RVA: 0x005170B8 File Offset: 0x005152B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnShopVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnShopVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnShopVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnShopVerify.<>O.<0>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
							{
								short typeIdVOffset = 20;
								short valueVOffset = 22;
								VerifyUnionAction verifyAction5;
								if ((verifyAction5 = INpcUiInteractOnShopVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (INpcUiInteractOnShopVerify.<>O.<1>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
								}
								if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction5, false))
								{
									short offsetId5 = 24;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = INpcUiInteractOnShopVerify.<>O.<0>__Verify) == null)
									{
										verifyAction6 = (INpcUiInteractOnShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
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

		// Token: 0x02007BBA RID: 31674
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013664 RID: 79460
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013665 RID: 79461
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
