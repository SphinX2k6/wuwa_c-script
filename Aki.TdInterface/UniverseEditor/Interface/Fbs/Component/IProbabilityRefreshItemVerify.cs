using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005786 RID: 22406
	public static class IProbabilityRefreshItemVerify
	{
		// Token: 0x06025906 RID: 153862 RVA: 0x0052E7B0 File Offset: 0x0052C9B0
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

		// Token: 0x02007BE5 RID: 31717
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136AA RID: 79530
			public static VerifyTableAction <0>__Verify;
		}
	}
}
