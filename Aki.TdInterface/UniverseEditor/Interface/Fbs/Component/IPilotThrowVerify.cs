using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005741 RID: 22337
	public static class IPilotThrowVerify
	{
		// Token: 0x060256C8 RID: 153288 RVA: 0x0052A0E8 File Offset: 0x005282E8
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

		// Token: 0x02007BD9 RID: 31705
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013698 RID: 79512
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013699 RID: 79513
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401369A RID: 79514
			public static VerifyTableAction <2>__Verify;
		}
	}
}
