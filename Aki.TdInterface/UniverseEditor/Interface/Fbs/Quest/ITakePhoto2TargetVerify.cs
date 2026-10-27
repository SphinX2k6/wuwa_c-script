using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418F RID: 16783
	public static class ITakePhoto2TargetVerify
	{
		// Token: 0x06018B0E RID: 101134 RVA: 0x0038E554 File Offset: 0x0038C754
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITakePhoto2TargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITakePhoto2TargetVerify.<>O.<0>__Verify = new VerifyTableAction(ITakePhoto2TargetCameraDistanceConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200795E RID: 31070
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132B5 RID: 78517
			public static VerifyTableAction <0>__Verify;
		}
	}
}
