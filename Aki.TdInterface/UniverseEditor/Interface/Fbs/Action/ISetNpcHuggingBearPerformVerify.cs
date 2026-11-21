using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007808 RID: 30728
	public static class ISetNpcHuggingBearPerformVerify
	{
		// Token: 0x06035FD4 RID: 221140 RVA: 0x0073B464 File Offset: 0x00739664
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcHuggingBearPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcHuggingBearPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086DB RID: 34523
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE2 RID: 84706
			public static VerifyTableAction <0>__Verify;
		}
	}
}
