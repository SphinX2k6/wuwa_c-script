using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F58 RID: 16216
	public static class INewHandInItemsConditionVerify
	{
		// Token: 0x060170F7 RID: 94455 RVA: 0x00353100 File Offset: 0x00351300
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

		// Token: 0x0200790E RID: 30990
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E3 RID: 78307
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131E4 RID: 78308
			public static VerifyTableAction <1>__Verify;
		}
	}
}
