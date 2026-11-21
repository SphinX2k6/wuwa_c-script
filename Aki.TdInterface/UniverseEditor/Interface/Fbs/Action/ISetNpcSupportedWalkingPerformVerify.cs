using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200780E RID: 30734
	public static class ISetNpcSupportedWalkingPerformVerify
	{
		// Token: 0x06036022 RID: 221218 RVA: 0x0073BFD8 File Offset: 0x0073A1D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetNpcSupportedWalkingPerformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNpcSupportedWalkingPerformVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerInitiatorVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086DD RID: 34525
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE6 RID: 84710
			public static VerifyTableAction <0>__Verify;
		}
	}
}
