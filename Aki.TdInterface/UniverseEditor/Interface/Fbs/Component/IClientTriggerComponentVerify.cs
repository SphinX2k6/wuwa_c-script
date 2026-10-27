using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FAE RID: 20398
	public static class IClientTriggerComponentVerify
	{
		// Token: 0x06020776 RID: 132982 RVA: 0x004845E0 File Offset: 0x004827E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientTriggerComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientTriggerComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITriggerMatchConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IClientTriggerComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IClientTriggerComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ITriggeredConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IClientTriggerComponentVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IClientTriggerComponentVerify.<>O.<1>__Verify = new VerifyTableAction(ITriggeredConfigVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AB3 RID: 31411
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134A0 RID: 79008
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134A1 RID: 79009
			public static VerifyTableAction <1>__Verify;
		}
	}
}
