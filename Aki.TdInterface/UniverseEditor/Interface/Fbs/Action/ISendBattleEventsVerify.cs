using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F62 RID: 28514
	public static class ISendBattleEventsVerify
	{
		// Token: 0x06032604 RID: 206340 RVA: 0x006CD0C8 File Offset: 0x006CB2C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISendBattleEventsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendBattleEventsVerify.<>O.<0>__Verify = new VerifyTableAction(ISetBattleTagConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E23 RID: 32291
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E0 RID: 80352
			public static VerifyTableAction <0>__Verify;
		}
	}
}
