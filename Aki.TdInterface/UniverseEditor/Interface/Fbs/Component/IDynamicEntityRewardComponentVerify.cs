using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005642 RID: 22082
	public static class IDynamicEntityRewardComponentVerify
	{
		// Token: 0x06023488 RID: 144520 RVA: 0x004DAD44 File Offset: 0x004D8F44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicEntityRewardComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicEntityRewardComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicTrafficRewardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicEntityRewardComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDynamicEntityRewardComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200833C RID: 33596
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014572 RID: 83314
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014573 RID: 83315
			public static VerifyTableAction <1>__Verify;
		}
	}
}
