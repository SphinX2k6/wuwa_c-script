using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048B6 RID: 18614
	public static class ICustomOnlineRefreshVerify
	{
		// Token: 0x0601B82C RID: 112684 RVA: 0x003E4314 File Offset: 0x003E2514
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

		// Token: 0x020081E2 RID: 33250
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014383 RID: 82819
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014384 RID: 82820
			public static VerifyTableAction <1>__Verify;
		}
	}
}
