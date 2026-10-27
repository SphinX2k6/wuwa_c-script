using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B81 RID: 27521
	public static class IMp4GamepadShakeVerify
	{
		// Token: 0x06030554 RID: 197972 RVA: 0x00691180 File Offset: 0x0068F380
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMp4GamepadShakeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMp4GamepadShakeVerify.<>O.<0>__Verify = new VerifyTableAction(IMp4GamepadShakeFadeInConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IMp4GamepadShakeVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IMp4GamepadShakeVerify.<>O.<1>__Verify = new VerifyTableAction(IMp4GamepadShakeFadeOutConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007DC3 RID: 32195
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013966 RID: 80230
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013967 RID: 80231
			public static VerifyTableAction <1>__Verify;
		}
	}
}
