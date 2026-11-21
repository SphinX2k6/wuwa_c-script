using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006102 RID: 24834
	public static class ITurntableConnectorComponentVerify
	{
		// Token: 0x0602A191 RID: 172433 RVA: 0x005BF108 File Offset: 0x005BD308
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITurntableConnectorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITurntableConnectorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICircuitConnectVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084E0 RID: 34016
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014835 RID: 84021
			public static VerifyTableAction <0>__Verify;
		}
	}
}
