using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200444E RID: 17486
	public static class ICustomOnlineRefreshVerify
	{
		// Token: 0x0601A05B RID: 106587 RVA: 0x003B8108 File Offset: 0x003B6308
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICustomOnlineRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomOnlineRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(ISingleOnlineRefreshVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICustomOnlineRefreshVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICustomOnlineRefreshVerify.<>O.<1>__Verify = new VerifyTableAction(IMultiplayerRefreshVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007999 RID: 31129
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401331C RID: 78620
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401331D RID: 78621
			public static VerifyTableAction <1>__Verify;
		}
	}
}
