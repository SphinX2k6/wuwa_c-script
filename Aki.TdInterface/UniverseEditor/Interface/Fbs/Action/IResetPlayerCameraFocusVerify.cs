using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007614 RID: 30228
	public static class IResetPlayerCameraFocusVerify
	{
		// Token: 0x060350B0 RID: 217264 RVA: 0x007200A4 File Offset: 0x0071E2A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IResetPlayerCameraFocusVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetPlayerCameraFocusVerify.<>O.<0>__Verify = new VerifyUnionAction(TResetPlayerFocusTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086A2 RID: 34466
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A95 RID: 84629
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
