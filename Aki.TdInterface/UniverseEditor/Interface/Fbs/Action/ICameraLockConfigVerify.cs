using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F1 RID: 26865
	public static class ICameraLockConfigVerify
	{
		// Token: 0x0602DFE5 RID: 188389 RVA: 0x00649378 File Offset: 0x00647578
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraLockConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraLockConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraLockTargetPositionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICameraLockConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICameraLockConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ICameraLockParamsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008573 RID: 34163
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014909 RID: 84233
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401490A RID: 84234
			public static VerifyTableAction <1>__Verify;
		}
	}
}
