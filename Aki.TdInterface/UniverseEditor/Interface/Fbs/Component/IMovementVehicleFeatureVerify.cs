using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B81 RID: 23425
	public static class IMovementVehicleFeatureVerify
	{
		// Token: 0x060269AF RID: 158127 RVA: 0x005496AC File Offset: 0x005478AC
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

		// Token: 0x02008402 RID: 33794
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146C5 RID: 83653
			public static VerifyTableAction <0>__Verify;
		}
	}
}
