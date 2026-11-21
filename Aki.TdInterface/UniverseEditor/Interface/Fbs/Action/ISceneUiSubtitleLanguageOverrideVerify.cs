using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D7 RID: 30423
	public static class ISceneUiSubtitleLanguageOverrideVerify
	{
		// Token: 0x06035614 RID: 218644 RVA: 0x00728EC0 File Offset: 0x007270C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleLanguageOverrideVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleLanguageOverrideVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitlePositionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B1 RID: 34481
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA8 RID: 84648
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
