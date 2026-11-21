using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CEE RID: 27886
	public static class IEnableNearbyTrackingVerify
	{
		// Token: 0x06030129 RID: 196905 RVA: 0x0068A2E8 File Offset: 0x006884E8
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

		// Token: 0x020085C5 RID: 34245
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014975 RID: 84341
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
