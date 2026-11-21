using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA7 RID: 23719
	public static class IPasserbyNpcPerNpcRandomExitIntervalVerify
	{
		// Token: 0x0602759C RID: 161180 RVA: 0x00562F8C File Offset: 0x0056118C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPasserbyNpcPerNpcRandomExitIntervalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPasserbyNpcPerNpcRandomExitIntervalVerify.<>O.<0>__Verify = new VerifyTableAction(IPasserbyNpcNearSplineStartFirstExitOrderVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008431 RID: 33841
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014711 RID: 83729
			public static VerifyTableAction <0>__Verify;
		}
	}
}
