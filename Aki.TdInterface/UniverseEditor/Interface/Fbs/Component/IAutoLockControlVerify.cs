using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE8 RID: 20200
	public static class IAutoLockControlVerify
	{
		// Token: 0x0601FD7C RID: 130428 RVA: 0x0046E2F4 File Offset: 0x0046C4F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAutoLockControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAutoLockControlVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAutoLockControlVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAutoLockControlVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A86 RID: 31366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013459 RID: 78937
			public static VerifyTableAction <0>__Verify;
		}
	}
}
