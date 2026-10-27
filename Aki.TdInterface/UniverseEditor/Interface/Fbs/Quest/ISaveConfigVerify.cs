using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040F9 RID: 16633
	public static class ISaveConfigVerify
	{
		// Token: 0x06018400 RID: 99328 RVA: 0x0037DAC4 File Offset: 0x0037BCC4
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

		// Token: 0x0200794F RID: 31055
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013270 RID: 78448
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013271 RID: 78449
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013272 RID: 78450
			public static VerifyTableAction <2>__Verify;
		}
	}
}
