using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004396 RID: 17302
	public static class INewHandInItemsConditionVerify
	{
		// Token: 0x06018759 RID: 100185 RVA: 0x0037C574 File Offset: 0x0037A774
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INewHandInItemsConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INewHandInItemsConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = INewHandInItemsConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (INewHandInItemsConditionVerify.<>O.<1>__Verify = new VerifyTableAction(INewHandInItemsProjectionMachineVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008154 RID: 33108
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014243 RID: 82499
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014244 RID: 82500
			public static VerifyTableAction <1>__Verify;
		}
	}
}
