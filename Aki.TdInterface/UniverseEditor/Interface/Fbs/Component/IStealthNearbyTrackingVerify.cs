using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CD RID: 22989
	public static class IStealthNearbyTrackingVerify
	{
		// Token: 0x06026FD7 RID: 159703 RVA: 0x0055D6F4 File Offset: 0x0055B8F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStealthNearbyTrackingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStealthNearbyTrackingVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C42 RID: 31810
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013737 RID: 79671
			public static VerifyTableAction <0>__Verify;
		}
	}
}
