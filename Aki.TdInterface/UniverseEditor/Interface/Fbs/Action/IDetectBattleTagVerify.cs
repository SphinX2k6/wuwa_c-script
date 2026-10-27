using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065BA RID: 26042
	public static class IDetectBattleTagVerify
	{
		// Token: 0x0602D2C0 RID: 185024 RVA: 0x006318B0 File Offset: 0x0062FAB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDetectBattleTagVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDetectBattleTagVerify.<>O.<0>__Verify = new VerifyTableAction(IDetectBattleMonsterOnGroundVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D40 RID: 32064
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138B5 RID: 80053
			public static VerifyTableAction <0>__Verify;
		}
	}
}
