using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BC RID: 21692
	public static class IChargeSlashHookVerify
	{
		// Token: 0x06022312 RID: 140050 RVA: 0x004B688C File Offset: 0x004B4A8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChargeSlashHookVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChargeSlashHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IChargeSlashHookVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IChargeSlashHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IChargeSlashHookVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IChargeSlashHookVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 12;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IChargeSlashHookVerify.<>O.<1>__Verify) == null)
							{
								verifyAction4 = (IChargeSlashHookVerify.<>O.<1>__Verify = new VerifyTableAction(IClientHookActionConfigVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false))
							{
								short offsetId5 = 18;
								VerifyTableAction verifyAction5;
								if ((verifyAction5 = IChargeSlashHookVerify.<>O.<2>__Verify) == null)
								{
									verifyAction5 = (IChargeSlashHookVerify.<>O.<2>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
								}
								if (verifier.VerifyTable(tablePos, offsetId5, verifyAction5, false) && verifier.VerifyField(tablePos, 20, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false))
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

		// Token: 0x02008300 RID: 33536
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401450A RID: 83210
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401450B RID: 83211
			public static VerifyTableAction <1>__Verify;

			// Token: 0x0401450C RID: 83212
			public static VerifyTableAction <2>__Verify;
		}
	}
}
