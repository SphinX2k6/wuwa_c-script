using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DC0 RID: 32192
	public static class IVisualNovelPerformanceSwitchAudioStateVerify
	{
		// Token: 0x0603A2CA RID: 238282 RVA: 0x007D7924 File Offset: 0x007D5B24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceSwitchAudioStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceSwitchAudioStateVerify.<>O.<0>__Verify = new VerifyTableAction(IAudioStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008771 RID: 34673
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D03 RID: 85251
			public static VerifyTableAction <0>__Verify;
		}
	}
}
