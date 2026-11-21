using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C17 RID: 23575
	public static class INpcUiInteractOnGramophoneVerify
	{
		// Token: 0x06026FED RID: 159725 RVA: 0x00556BC8 File Offset: 0x00554DC8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnGramophoneVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnGramophoneVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnGramophoneVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnGramophoneVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 18;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = INpcUiInteractOnGramophoneVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (INpcUiInteractOnGramophoneVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0200841A RID: 33818
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146F1 RID: 83697
			public static VerifyTableAction <0>__Verify;
		}
	}
}
