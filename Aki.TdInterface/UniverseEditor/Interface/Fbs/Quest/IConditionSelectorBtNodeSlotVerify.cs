using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DB7 RID: 15799
	public static class IConditionSelectorBtNodeSlotVerify
	{
		// Token: 0x0601608D RID: 90253 RVA: 0x0032F920 File Offset: 0x0032DB20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionSelectorBtNodeSlotVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionSelectorBtNodeSlotVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IConditionSelectorBtNodeSlotVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IConditionSelectorBtNodeSlotVerify.<>O.<1>__Verify = new VerifyUnionAction(TBtNodeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						short offsetId2 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IConditionSelectorBtNodeSlotVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (IConditionSelectorBtNodeSlotVerify.<>O.<2>__Verify = new VerifyTableAction(IPerformanceSettingVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId2, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020078CB RID: 30923
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013167 RID: 78183
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013168 RID: 78184
			public static VerifyUnionAction <1>__Verify;

			// Token: 0x04013169 RID: 78185
			public static VerifyTableAction <2>__Verify;
		}
	}
}
