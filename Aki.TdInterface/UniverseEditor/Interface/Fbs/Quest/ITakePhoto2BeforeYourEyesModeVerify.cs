using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045BE RID: 17854
	public static class ITakePhoto2BeforeYourEyesModeVerify
	{
		// Token: 0x0601A0C6 RID: 106694 RVA: 0x003B63D8 File Offset: 0x003B45D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITakePhoto2BeforeYourEyesModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2BeforeYourEyesModeVerify.<>O.<0>__Verify = new VerifyUnionAction(TTakePhoto2SuccessCameraBehaviorVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081A2 RID: 33186
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401430B RID: 82699
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
