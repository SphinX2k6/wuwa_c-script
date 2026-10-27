using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F8D RID: 20365
	public static class IChargeSlashHookVerify
	{
		// Token: 0x060205C0 RID: 132544 RVA: 0x0048089C File Offset: 0x0047EA9C
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

		// Token: 0x02007AAA RID: 31402
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013494 RID: 78996
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013495 RID: 78997
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013496 RID: 78998
			public static VerifyTableAction <2>__Verify;
		}
	}
}
