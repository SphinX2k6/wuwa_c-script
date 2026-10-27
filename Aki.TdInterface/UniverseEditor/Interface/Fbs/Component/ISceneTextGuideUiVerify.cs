using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DE RID: 22750
	public static class ISceneTextGuideUiVerify
	{
		// Token: 0x06026699 RID: 157337 RVA: 0x0054B2CC File Offset: 0x005494CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneTextGuideUiVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneTextGuideUiVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneTextGuideUiScaleConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneTextGuideUiVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneTextGuideUiVerify.<>O.<1>__Verify = new VerifyTableAction(ISceneTextGuideUiContentVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C23 RID: 31779
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013706 RID: 79622
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013707 RID: 79623
			public static VerifyTableAction <1>__Verify;
		}
	}
}
