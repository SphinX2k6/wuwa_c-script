using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200453A RID: 17722
	public static class ISaveConfigVerify
	{
		// Token: 0x06019AA1 RID: 105121 RVA: 0x003A7A14 File Offset: 0x003A5C14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISaveConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISaveConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPosRollbackConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISaveConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISaveConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ISaveConfigVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ISaveConfigVerify.<>O.<2>__Verify = new VerifyTableAction(IInitConditionActionsVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02008196 RID: 33174
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142D3 RID: 82643
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040142D4 RID: 82644
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040142D5 RID: 82645
			public static VerifyTableAction <2>__Verify;
		}
	}
}
