using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F1 RID: 23025
	public static class ISuiGuangHookVerify
	{
		// Token: 0x0602712D RID: 160045 RVA: 0x00560284 File Offset: 0x0055E484
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISuiGuangHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISuiGuangHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISuiGuangHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISuiGuangHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISuiGuangHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ISuiGuangHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISuiGuangHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (ISuiGuangHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
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

		// Token: 0x02007C46 RID: 31814
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401373E RID: 79678
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401373F RID: 79679
			public static VerifyTableAction <1>__Verify;
		}
	}
}
