using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D8D RID: 23949
	public static class IProbabilityRefreshItemVerify
	{
		// Token: 0x06027E26 RID: 163366 RVA: 0x0057493C File Offset: 0x00572B3C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProbabilityRefreshItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProbabilityRefreshItemVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008453 RID: 33875
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401474A RID: 83786
			public static VerifyTableAction <0>__Verify;
		}
	}
}
