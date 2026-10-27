using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050AA RID: 20650
	public static class IDollGrabShowcaseDollCameraConfigVerify
	{
		// Token: 0x060212C8 RID: 135880 RVA: 0x0049C03C File Offset: 0x0049A23C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollGrabShowcaseDollCameraConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollGrabShowcaseDollCameraConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IShowcaseFullViewCameraConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDollGrabShowcaseDollCameraConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IDollGrabShowcaseDollCameraConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IDollComboCameraVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007ADB RID: 31451
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134E7 RID: 79079
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040134E8 RID: 79080
			public static VerifyTableAction <1>__Verify;
		}
	}
}
