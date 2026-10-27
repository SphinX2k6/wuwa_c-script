using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C7 RID: 30151
	public static class IVisualNovelPerformanceSwitchAudioStateVerify
	{
		// Token: 0x06036E9B RID: 224923 RVA: 0x0077419C File Offset: 0x0077239C
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

		// Token: 0x02007ED5 RID: 32469
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C27 RID: 80935
			public static VerifyTableAction <0>__Verify;
		}
	}
}
