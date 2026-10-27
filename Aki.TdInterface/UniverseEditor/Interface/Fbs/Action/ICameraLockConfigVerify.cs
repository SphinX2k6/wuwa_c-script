using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006280 RID: 25216
	public static class ICameraLockConfigVerify
	{
		// Token: 0x0602B884 RID: 178308 RVA: 0x005FE570 File Offset: 0x005FC770
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

		// Token: 0x02007D00 RID: 32000
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013861 RID: 79969
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013862 RID: 79970
			public static VerifyTableAction <1>__Verify;
		}
	}
}
