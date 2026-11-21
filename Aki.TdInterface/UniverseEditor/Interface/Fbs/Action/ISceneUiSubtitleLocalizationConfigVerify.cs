using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DA RID: 30426
	public static class ISceneUiSubtitleLocalizationConfigVerify
	{
		// Token: 0x0603562C RID: 218668 RVA: 0x00729221 File Offset: 0x00727421
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleLocalizationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleLocalizationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneUiSubtitleLanguageOverrideVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086B2 RID: 34482
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA9 RID: 84649
			public static VerifyTableAction <0>__Verify;
		}
	}
}
