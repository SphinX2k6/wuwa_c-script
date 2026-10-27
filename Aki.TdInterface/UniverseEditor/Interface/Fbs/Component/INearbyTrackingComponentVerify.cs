using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F5 RID: 22005
	public static class INearbyTrackingComponentVerify
	{
		// Token: 0x0602482E RID: 149550 RVA: 0x0050A098 File Offset: 0x00508298
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

		// Token: 0x02007BA2 RID: 31650
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013638 RID: 79416
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
