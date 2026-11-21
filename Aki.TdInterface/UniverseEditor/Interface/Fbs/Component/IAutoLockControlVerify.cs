using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005417 RID: 21527
	public static class IAutoLockControlVerify
	{
		// Token: 0x06021AC0 RID: 137920 RVA: 0x004A40C4 File Offset: 0x004A22C4
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

		// Token: 0x020082DC RID: 33500
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144CF RID: 83151
			public static VerifyTableAction <0>__Verify;
		}
	}
}
