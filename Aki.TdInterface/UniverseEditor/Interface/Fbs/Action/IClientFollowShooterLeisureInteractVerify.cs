using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C0 RID: 25536
	public static class IClientFollowShooterLeisureInteractVerify
	{
		// Token: 0x0602C2C8 RID: 180936 RVA: 0x00610BDC File Offset: 0x0060EDDC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IClientFollowShooterLeisureInteractVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientFollowShooterLeisureInteractVerify.<>O.<0>__Verify = new VerifyUnionAction(TClientFollowShooterLeisureTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D1E RID: 32030
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013889 RID: 80009
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
