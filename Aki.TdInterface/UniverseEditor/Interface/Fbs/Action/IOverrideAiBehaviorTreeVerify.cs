using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073BD RID: 29629
	public static class IOverrideAiBehaviorTreeVerify
	{
		// Token: 0x06033D41 RID: 212289 RVA: 0x006FD9F4 File Offset: 0x006FBBF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOverrideAiBehaviorTreeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOverrideAiBehaviorTreeVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonBtOverrideVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IOverrideAiBehaviorTreeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IOverrideAiBehaviorTreeVerify.<>O.<1>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200866B RID: 34411
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A54 RID: 84564
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A55 RID: 84565
			public static VerifyTableAction <1>__Verify;
		}
	}
}
