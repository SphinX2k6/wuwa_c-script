using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FDA RID: 24538
	public static class IStealthNearbyTrackingVerify
	{
		// Token: 0x0602954F RID: 169295 RVA: 0x005A46B8 File Offset: 0x005A28B8
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

		// Token: 0x020084B1 RID: 33969
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147DB RID: 83931
			public static VerifyTableAction <0>__Verify;
		}
	}
}
