using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E3 RID: 30435
	public static class ISceneUiSubtitlePositionVerify
	{
		// Token: 0x06035662 RID: 218722 RVA: 0x00729754 File Offset: 0x00727954
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneUiSubtitlePositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitlePositionVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAndRotVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B3 RID: 34483
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AAA RID: 84650
			public static VerifyTableAction <0>__Verify;
		}
	}
}
