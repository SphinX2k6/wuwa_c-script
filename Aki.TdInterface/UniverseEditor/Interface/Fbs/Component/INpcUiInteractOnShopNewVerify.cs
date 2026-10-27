using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567F RID: 22143
	public static class INpcUiInteractOnShopNewVerify
	{
		// Token: 0x06024E66 RID: 151142 RVA: 0x00517F34 File Offset: 0x00516134
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcUiInteractOnShopNewVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnShopNewVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnShopNewVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnShopNewVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						short typeIdVOffset3 = 14;
						short valueVOffset3 = 16;
						VerifyUnionAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnShopNewVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnShopNewVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
						}
						if (verifier.VerifyUnion(tablePos, typeIdVOffset3, valueVOffset3, verifyAction3, false))
						{
							short offsetId = 18;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnShopNewVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnShopNewVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId, verifyAction4, false))
							{
								short offsetId2 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = INpcUiInteractOnShopNewVerify.<>O.<1>__Verify) == null)
								{
									verifyAction5 = (INpcUiInteractOnShopNewVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId2, verifyAction5, false))
								{
									short offsetId3 = 22;
									VerifyTableAction verifyAction6;
									if ((verifyAction6 = INpcUiInteractOnShopNewVerify.<>O.<1>__Verify) == null)
									{
										verifyAction6 = (INpcUiInteractOnShopNewVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
									}
									if (verifier.VerifyTable(tablePos, offsetId3, verifyAction6, false))
									{
										short offsetId4 = 24;
										VerifyTableAction verifyAction7;
										if ((verifyAction7 = INpcUiInteractOnShopNewVerify.<>O.<1>__Verify) == null)
										{
											verifyAction7 = (INpcUiInteractOnShopNewVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
										}
										if (verifier.VerifyTable(tablePos, offsetId4, verifyAction7, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
										{
											short typeIdVOffset4 = 26;
											short valueVOffset4 = 28;
											VerifyUnionAction verifyAction8;
											if ((verifyAction8 = INpcUiInteractOnShopNewVerify.<>O.<0>__Verify) == null)
											{
												verifyAction8 = (INpcUiInteractOnShopNewVerify.<>O.<0>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
											}
											if (verifier.VerifyUnion(tablePos, typeIdVOffset4, valueVOffset4, verifyAction8, false))
											{
												short offsetId5 = 30;
												VerifyTableAction verifyAction9;
												if ((verifyAction9 = INpcUiInteractOnShopNewVerify.<>O.<1>__Verify) == null)
												{
													verifyAction9 = (INpcUiInteractOnShopNewVerify.<>O.<1>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
												}
												if (verifier.VerifyTable(tablePos, offsetId5, verifyAction9, false))
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

		// Token: 0x02007BBB RID: 31675
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013666 RID: 79462
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04013667 RID: 79463
			public static VerifyTableAction <1>__Verify;
		}
	}
}
