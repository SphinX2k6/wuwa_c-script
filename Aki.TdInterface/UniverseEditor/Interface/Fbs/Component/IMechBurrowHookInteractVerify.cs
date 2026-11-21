using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC7 RID: 23239
	public static class IMechBurrowHookInteractVerify
	{
		// Token: 0x060261DE RID: 156126 RVA: 0x00538C10 File Offset: 0x00536E10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechBurrowHookInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechBurrowHookInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMechBurrowHookInteractVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IMechBurrowHookInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IMechBurrowHookInteractVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IMechBurrowHookInteractVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IMechBurrowHookInteractVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IMechBurrowHookInteractVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false))
							{
								short offsetId5 = 14;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IMechBurrowHookInteractVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IMechBurrowHookInteractVerify.<>O.<2>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
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

		// Token: 0x020083EB RID: 33771
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014697 RID: 83607
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014698 RID: 83608
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04014699 RID: 83609
			public static VerifyTableAction <2>__Verify;
		}
	}
}
