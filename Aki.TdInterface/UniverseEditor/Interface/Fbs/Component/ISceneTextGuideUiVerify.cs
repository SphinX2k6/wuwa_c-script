using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EEB RID: 24299
	public static class ISceneTextGuideUiVerify
	{
		// Token: 0x06028BFB RID: 166907 RVA: 0x00591E18 File Offset: 0x00590018
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

		// Token: 0x02008492 RID: 33938
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147A8 RID: 83880
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040147A9 RID: 83881
			public static VerifyTableAction <1>__Verify;
		}
	}
}
