using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005977 RID: 22903
	public static class IIndependentSystemRewardComponentVerify
	{
		// Token: 0x06025560 RID: 152928 RVA: 0x0051FDC4 File Offset: 0x0051DFC4
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

		// Token: 0x020083C2 RID: 33730
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401464B RID: 83531
			public static VerifyTableAction <0>__Verify;
		}
	}
}
