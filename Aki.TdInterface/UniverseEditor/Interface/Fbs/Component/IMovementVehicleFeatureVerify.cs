using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E3 RID: 21987
	public static class IMovementVehicleFeatureVerify
	{
		// Token: 0x060247A2 RID: 149410 RVA: 0x00509134 File Offset: 0x00507334
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMovementVehicleFeatureVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMovementVehicleFeatureVerify.<>O.<0>__Verify = new VerifyTableAction(IMovementPerformConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BA0 RID: 31648
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013636 RID: 79414
			public static VerifyTableAction <0>__Verify;
		}
	}
}
