using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006004 RID: 24580
	public static class ISunSpiritCollectComponentVerify
	{
		// Token: 0x060296DD RID: 169693 RVA: 0x005A7974 File Offset: 0x005A5B74
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

		// Token: 0x020084B7 RID: 33975
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147E5 RID: 83941
			public static VerifyTableAction <0>__Verify;
		}
	}
}
