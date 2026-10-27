using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FFF RID: 20479
	public static class ICondtionListenerVerify
	{
		// Token: 0x06020BFC RID: 134140 RVA: 0x0048DCF0 File Offset: 0x0048BEF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICondtionListenerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICondtionListenerVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICondtionListenerVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICondtionListenerVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = ICondtionListenerVerify.<>O.<2>__Verify) == null)
						{
							verifyAction3 = (ICondtionListenerVerify.<>O.<2>__Verify = new VerifyTableAction(IConditionActionVerify.Verify));
						}
						if (verifier.VerifyVectorOfTables(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x02007AC2 RID: 31426
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134B6 RID: 79030
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134B7 RID: 79031
			public static VerifyTableAction <1>__Verify;

			// Token: 0x040134B8 RID: 79032
			public static VerifyTableAction <2>__Verify;
		}
	}
}
