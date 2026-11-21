using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078BF RID: 30911
	public static class IShowTalkCameraMotionPresetVerify
	{
		// Token: 0x060366AC RID: 222892 RVA: 0x00749724 File Offset: 0x00747924
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTalkCameraMotionPresetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTalkCameraMotionPresetVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowCameraShakeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086F3 RID: 34547
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B0C RID: 84748
			public static VerifyTableAction <0>__Verify;
		}
	}
}
