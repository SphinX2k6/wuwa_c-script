using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200592B RID: 22827
	public static class ISlashHookVerify
	{
		// Token: 0x060269CF RID: 158159 RVA: 0x00551780 File Offset: 0x0054F980
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISlashHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlashHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISlashHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ISlashHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISlashHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (ISlashHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = ISlashHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (ISlashHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
							{
								short offsetId5 = 20;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = ISlashHookVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (ISlashHookVerify.<>O.<2>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false))
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

		// Token: 0x02007C2E RID: 31790
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013714 RID: 79636
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013715 RID: 79637
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013716 RID: 79638
			public static VerifyTableAction <2>__Verify;
		}
	}
}
