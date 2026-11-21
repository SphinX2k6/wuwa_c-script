using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005537 RID: 21815
	public static class ICompassTrackingVerify
	{
		// Token: 0x0602281E RID: 141342 RVA: 0x004C0DD8 File Offset: 0x004BEFD8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICompassTrackingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompassTrackingVerify.<>O.<0>__Verify = new VerifyTableAction(IIconNearByTrackingConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008312 RID: 33554
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014524 RID: 83236
			public static VerifyTableAction <0>__Verify;
		}
	}
}
