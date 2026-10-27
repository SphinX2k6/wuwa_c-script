using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005676 RID: 22134
	public static class INpcUiInteractOnGramophoneVerify
	{
		// Token: 0x06024DB4 RID: 150964 RVA: 0x0051602C File Offset: 0x0051422C
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

		// Token: 0x02007BB8 RID: 31672
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013662 RID: 79458
			public static VerifyTableAction <0>__Verify;
		}
	}
}
