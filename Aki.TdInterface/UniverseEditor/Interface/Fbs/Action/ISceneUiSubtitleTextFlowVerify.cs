using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FE RID: 30462
	public static class ISceneUiSubtitleTextFlowVerify
	{
		// Token: 0x06035730 RID: 218928 RVA: 0x0072AF38 File Offset: 0x00729138
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleTextFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleTextFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B6 RID: 34486
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AAF RID: 84655
			public static VerifyTableAction <0>__Verify;
		}
	}
}
