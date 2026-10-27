using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E73 RID: 20083
	public static class IAiAlertNotifyComponentVerify
	{
		// Token: 0x0601F8D9 RID: 129241 RVA: 0x00464E30 File Offset: 0x00463030
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAiAlertNotifyComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAiAlertNotifyComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IExtraAiAlertVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A75 RID: 31349
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013442 RID: 78914
			public static VerifyTableAction <0>__Verify;
		}
	}
}
