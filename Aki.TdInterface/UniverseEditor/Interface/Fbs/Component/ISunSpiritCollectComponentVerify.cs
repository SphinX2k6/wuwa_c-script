using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F7 RID: 23031
	public static class ISunSpiritCollectComponentVerify
	{
		// Token: 0x06027165 RID: 160101 RVA: 0x005609B0 File Offset: 0x0055EBB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISunSpiritCollectComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISunSpiritCollectComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ISunSpiritPlayerBattleConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C48 RID: 31816
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013741 RID: 79681
			public static VerifyTableAction <0>__Verify;
		}
	}
}
