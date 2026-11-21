using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D1 RID: 30417
	public static class ISceneUiSubtitleAppearVerify
	{
		// Token: 0x060355CA RID: 218570 RVA: 0x007283F0 File Offset: 0x007265F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleAppearVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleAppearVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitlePositionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneUiSubtitleAppearVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneUiSubtitleAppearVerify.<>O.<1>__Verify = new VerifyTableAction(ISceneUiSubtitleLocalizationConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086AF RID: 34479
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA4 RID: 84644
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014AA5 RID: 84645
			public static VerifyTableAction <1>__Verify;
		}
	}
}
