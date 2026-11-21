using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007805 RID: 30725
	public static class ISetNpcHighFivePerformVerify
	{
		// Token: 0x06035FB6 RID: 221110 RVA: 0x0073B0C4 File Offset: 0x007392C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcHighFivePerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcHighFivePerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086DA RID: 34522
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE1 RID: 84705
			public static VerifyTableAction <0>__Verify;
		}
	}
}
