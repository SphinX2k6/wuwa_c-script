using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F65 RID: 28517
	public static class ISendBattleEventsForMonsterSummonVerify
	{
		// Token: 0x06032620 RID: 206368 RVA: 0x006CD474 File Offset: 0x006CB674
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

		// Token: 0x02007E24 RID: 32292
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E1 RID: 80353
			public static VerifyTableAction <0>__Verify;
		}
	}
}
