using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D48 RID: 23880
	public static class IPilotThrowVerify
	{
		// Token: 0x06027BE8 RID: 162792 RVA: 0x00570274 File Offset: 0x0056E474
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPilotThrowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPilotThrowVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPilotThrowVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IPilotThrowVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IPilotThrowVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IPilotThrowVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IPilotThrowVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IPilotThrowVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 4UL, 4UL, false))
							{
								short offsetId5 = 28;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IPilotThrowVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IPilotThrowVerify.<>O.<2>__Verify = new VerifyTableAction(IPilotThrowTargetVerify.Verify));
								}
								if (verifier.VerifyVectorOfTables(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 30, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 32, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 34, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 36, 1UL, 1UL, false))
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

		// Token: 0x02008447 RID: 33863
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014738 RID: 83768
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014739 RID: 83769
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401473A RID: 83770
			public static VerifyTableAction <2>__Verify;
		}
	}
}
