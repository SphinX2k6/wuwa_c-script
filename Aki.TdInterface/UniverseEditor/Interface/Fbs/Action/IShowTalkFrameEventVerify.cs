using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FC RID: 28924
	public static class IShowTalkFrameEventVerify
	{
		// Token: 0x06033458 RID: 210008 RVA: 0x006E9BD0 File Offset: 0x006E7DD0
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

		// Token: 0x02007E5F RID: 32351
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A3B RID: 80443
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013A3C RID: 80444
			public static VerifyTableAction <1>__Verify;
		}
	}
}
