using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007728 RID: 30504
	public static class ISendBattleEventsForMonsterSummonVerify
	{
		// Token: 0x0603585E RID: 219230 RVA: 0x0072CCB4 File Offset: 0x0072AEB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISendBattleEventsForMonsterSummonVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendBattleEventsForMonsterSummonVerify.<>O.<0>__Verify = new VerifyTableAction(ISendBattleEventsForMonsterSummonConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B8 RID: 34488
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB1 RID: 84657
			public static VerifyTableAction <0>__Verify;
		}
	}
}
