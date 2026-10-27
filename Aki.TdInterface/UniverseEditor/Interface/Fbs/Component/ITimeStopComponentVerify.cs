using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB9 RID: 23225
	public static class ITimeStopComponentVerify
	{
		// Token: 0x06027929 RID: 162089 RVA: 0x005715D8 File Offset: 0x0056F7D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimeStopComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimeStopComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITimeStopTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C66 RID: 31846
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401377B RID: 79739
			public static VerifyTableAction <0>__Verify;
		}
	}
}
