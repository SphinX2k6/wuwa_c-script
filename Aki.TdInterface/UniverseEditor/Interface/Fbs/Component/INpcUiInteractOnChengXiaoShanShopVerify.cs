using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005670 RID: 22128
	public static class INpcUiInteractOnChengXiaoShanShopVerify
	{
		// Token: 0x06024D5C RID: 150876 RVA: 0x0051528C File Offset: 0x0051348C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnChengXiaoShanShopVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnChengXiaoShanShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnChengXiaoShanShopVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnChengXiaoShanShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnChengXiaoShanShopVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnChengXiaoShanShopVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyString(tablePos, 20, false) && verifier.VerifyField(tablePos, 22, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007BB6 RID: 31670
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013660 RID: 79456
			public static VerifyTableAction <0>__Verify;
		}
	}
}
