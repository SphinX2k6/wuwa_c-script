using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A09 RID: 23049
	public static class ISunSpiritLauncherVerify
	{
		// Token: 0x06027207 RID: 160263 RVA: 0x00561E78 File Offset: 0x00560078
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISunSpiritLauncherVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISunSpiritLauncherVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISunSpiritLauncherVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISunSpiritLauncherVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISunSpiritLauncherVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ISunSpiritLauncherVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISunSpiritLauncherVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (ISunSpiritLauncherVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007C4B RID: 31819
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013744 RID: 79684
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013745 RID: 79685
			public static VerifyTableAction <1>__Verify;
		}
	}
}
