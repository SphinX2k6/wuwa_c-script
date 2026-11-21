using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005384 RID: 21380
	public static class IAiAlertNotifyComponentVerify
	{
		// Token: 0x06021524 RID: 136484 RVA: 0x00498E48 File Offset: 0x00497048
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

		// Token: 0x020082C7 RID: 33479
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144B2 RID: 83122
			public static VerifyTableAction <0>__Verify;
		}
	}
}
