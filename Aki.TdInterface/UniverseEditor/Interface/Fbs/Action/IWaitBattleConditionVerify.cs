using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E08 RID: 32264
	public static class IWaitBattleConditionVerify
	{
		// Token: 0x0603A4EE RID: 238830 RVA: 0x007DB125 File Offset: 0x007D9325
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaitBattleConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaitBattleConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IDetectBattleTagVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008776 RID: 34678
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D08 RID: 85256
			public static VerifyTableAction <0>__Verify;
		}
	}
}
