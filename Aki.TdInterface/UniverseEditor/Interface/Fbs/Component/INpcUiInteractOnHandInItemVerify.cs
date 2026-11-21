using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1A RID: 23578
	public static class INpcUiInteractOnHandInItemVerify
	{
		// Token: 0x06027019 RID: 159769 RVA: 0x005571E0 File Offset: 0x005553E0
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

		// Token: 0x0200841B RID: 33819
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146F2 RID: 83698
			public static VerifyTableAction <0>__Verify;
		}
	}
}
