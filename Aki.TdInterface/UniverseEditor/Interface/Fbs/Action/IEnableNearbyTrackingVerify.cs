using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667A RID: 26234
	public static class IEnableNearbyTrackingVerify
	{
		// Token: 0x0602D940 RID: 186688 RVA: 0x0063D54C File Offset: 0x0063B74C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEnableNearbyTrackingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEnableNearbyTrackingVerify.<>O.<0>__Verify = new VerifyUnionAction(TControlTrackingTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D4E RID: 32078
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138C9 RID: 80073
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
