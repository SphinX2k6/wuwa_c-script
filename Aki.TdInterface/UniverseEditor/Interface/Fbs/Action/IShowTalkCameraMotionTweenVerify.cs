using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C2 RID: 30914
	public static class IShowTalkCameraMotionTweenVerify
	{
		// Token: 0x060366D6 RID: 222934 RVA: 0x00749D18 File Offset: 0x00747F18
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTalkCameraMotionTweenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTalkCameraMotionTweenVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraParamsVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IShowTalkCameraMotionTweenVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IShowTalkCameraMotionTweenVerify.<>O.<0>__Verify = new VerifyTableAction(ICameraParamsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IShowTalkCameraMotionTweenVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IShowTalkCameraMotionTweenVerify.<>O.<1>__Verify = new VerifyTableAction(IFlowCameraShakeVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020086F4 RID: 34548
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B0D RID: 84749
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B0E RID: 84750
			public static VerifyTableAction <1>__Verify;
		}
	}
}
