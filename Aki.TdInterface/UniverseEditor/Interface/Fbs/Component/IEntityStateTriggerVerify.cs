using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051BE RID: 20926
	public static class IEntityStateTriggerVerify
	{
		// Token: 0x06021E8F RID: 138895 RVA: 0x004B4470 File Offset: 0x004B2670
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityStateTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityStateTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityGroupConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IEntityStateTriggerVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IEntityStateTriggerVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 8;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IEntityStateTriggerVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IEntityStateTriggerVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false))
						{
							short offsetId4 = 10;
							VerifyTableAction verifyAction4;
							if ((verifyAction4 = IEntityStateTriggerVerify.<>O.<2>__Verify) == null)
							{
								verifyAction4 = (IEntityStateTriggerVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
							}
							if (verifier.VerifyTable(tablePos, offsetId4, verifyAction4, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
							{
								return verifier.VerifyTableEnd(tablePos);
							}
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007B06 RID: 31494
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401352E RID: 79150
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401352F RID: 79151
			public static VerifyTableAction <1>__Verify;

			// Token: 0x04013530 RID: 79152
			public static VerifyTableAction <2>__Verify;
		}
	}
}
