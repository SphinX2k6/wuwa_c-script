using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004445 RID: 17477
	public static class IChildDestroyOrAwardedRefreshVerify
	{
		// Token: 0x0601A00D RID: 106509 RVA: 0x003B7850 File Offset: 0x003B5A50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChildDestroyOrAwardedRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChildDestroyOrAwardedRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayRefreshCdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IChildDestroyOrAwardedRefreshVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IChildDestroyOrAwardedRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayRefreshCdVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007998 RID: 31128
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401331B RID: 78619
			public static VerifyTableAction <0>__Verify;
		}
	}
}
