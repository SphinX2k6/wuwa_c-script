using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048AD RID: 18605
	public static class IChildDestroyOrAwardedRefreshVerify
	{
		// Token: 0x0601B7DE RID: 112606 RVA: 0x003E3A5C File Offset: 0x003E1C5C
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

		// Token: 0x020081E1 RID: 33249
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014382 RID: 82818
			public static VerifyTableAction <0>__Verify;
		}
	}
}
