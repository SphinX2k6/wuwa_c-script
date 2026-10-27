using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566D RID: 22125
	public static class INpcUiInteractOnAntiqueShopVerify
	{
		// Token: 0x06024D18 RID: 150808 RVA: 0x005148A0 File Offset: 0x00512AA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
						{
							short typeIdVOffset = 20;
							short valueVOffset = 22;
							VerifyUnionAction verifyAction4;
							if ((verifyAction4 = INpcUiInteractOnAntiqueShopVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (INpcUiInteractOnAntiqueShopVerify.<>O.<1>__Verify = new VerifyUnionAction(TMontageConfigVerify.Verify));
							}
							if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction4, false))
							{
								short offsetId4 = 24;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify) == null)
								{
									verifyAction5 = (INpcUiInteractOnAntiqueShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId4, verifyAction5, false))
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

		// Token: 0x02007BB5 RID: 31669
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401365E RID: 79454
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401365F RID: 79455
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
