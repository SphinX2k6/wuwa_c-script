using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560F RID: 22031
	public static class IDollGrabShowcaseDollCameraConfigVerify
	{
		// Token: 0x0602321C RID: 143900 RVA: 0x004D5FC8 File Offset: 0x004D41C8
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

		// Token: 0x02008335 RID: 33589
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014565 RID: 83301
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014566 RID: 83302
			public static VerifyTableAction <1>__Verify;
		}
	}
}
