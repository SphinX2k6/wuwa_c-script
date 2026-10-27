using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F1 RID: 21489
	public static class IIndependentSystemRewardComponentVerify
	{
		// Token: 0x060234A8 RID: 144552 RVA: 0x004E2D98 File Offset: 0x004E0F98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IIndependentSystemRewardComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IIndependentSystemRewardComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDarkTideIndependentSystemRewardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B63 RID: 31587
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135C5 RID: 79301
			public static VerifyTableAction <0>__Verify;
		}
	}
}
