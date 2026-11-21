using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B93 RID: 23443
	public static class INearbyTrackingComponentVerify
	{
		// Token: 0x06026A3C RID: 158268 RVA: 0x0054A66C File Offset: 0x0054886C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
			{
				short typeIdVOffset = 12;
				short valueVOffset = 14;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INearbyTrackingComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INearbyTrackingComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TNearbyTrackingVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008404 RID: 33796
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146C7 RID: 83655
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
