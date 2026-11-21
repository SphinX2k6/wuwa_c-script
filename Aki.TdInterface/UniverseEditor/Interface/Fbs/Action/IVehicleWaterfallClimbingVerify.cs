using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D33 RID: 32051
	public static class IVehicleWaterfallClimbingVerify
	{
		// Token: 0x06039DD3 RID: 237011 RVA: 0x007CE754 File Offset: 0x007CC954
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVehicleWaterfallClimbingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVehicleWaterfallClimbingVerify.<>O.<0>__Verify = new VerifyTableAction(IVehicleWaterfallClimbGravityConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008763 RID: 34659
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CEF RID: 85231
			public static VerifyTableAction <0>__Verify;
		}
	}
}
