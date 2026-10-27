using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F3 RID: 28915
	public static class IShowTalkCameraMotionPresetVerify
	{
		// Token: 0x0603340A RID: 209930 RVA: 0x006E9118 File Offset: 0x006E7318
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

		// Token: 0x02007E5D RID: 32349
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A38 RID: 80440
			public static VerifyTableAction <0>__Verify;
		}
	}
}
