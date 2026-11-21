using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D4 RID: 21716
	public static class ICircuitConnectVerify
	{
		// Token: 0x06022470 RID: 140400 RVA: 0x004B9A8C File Offset: 0x004B7C8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICircuitConnectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICircuitConnectVerify.<>O.<0>__Verify = new VerifyTableAction(ICircuitConnectLevelDataVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008306 RID: 33542
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014513 RID: 83219
			public static VerifyTableAction <0>__Verify;
		}
	}
}
