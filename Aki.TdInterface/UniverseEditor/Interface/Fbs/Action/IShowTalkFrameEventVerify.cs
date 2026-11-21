using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078C8 RID: 30920
	public static class IShowTalkFrameEventVerify
	{
		// Token: 0x060366FA RID: 222970 RVA: 0x0074A1DC File Offset: 0x007483DC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTalkFrameEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTalkFrameEventVerify.<>O.<0>__Verify = new VerifyTableAction(ISequenceFrameEventVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IShowTalkFrameEventVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IShowTalkFrameEventVerify.<>O.<1>__Verify = new VerifyTableAction(IShowTalkFrameEventPositionVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086F5 RID: 34549
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B0F RID: 84751
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014B10 RID: 84752
			public static VerifyTableAction <1>__Verify;
		}
	}
}
