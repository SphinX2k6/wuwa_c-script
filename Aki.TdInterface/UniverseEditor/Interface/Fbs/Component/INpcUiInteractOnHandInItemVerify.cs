using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005679 RID: 22137
	public static class INpcUiInteractOnHandInItemVerify
	{
		// Token: 0x06024DE0 RID: 151008 RVA: 0x00516644 File Offset: 0x00514844
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcUiInteractOnHandInItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcUiInteractOnHandInItemVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INpcUiInteractOnHandInItemVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (INpcUiInteractOnHandInItemVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007BB9 RID: 31673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013663 RID: 79459
			public static VerifyTableAction <0>__Verify;
		}
	}
}
