using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005723 RID: 22307
	public static class IEntityStateTriggerVerify
	{
		// Token: 0x06023DE7 RID: 146919 RVA: 0x004EE4D8 File Offset: 0x004EC6D8
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

		// Token: 0x02008360 RID: 33632
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145AC RID: 83372
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145AD RID: 83373
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040145AE RID: 83374
			public static VerifyTableAction <2>__Verify;
		}
	}
}
