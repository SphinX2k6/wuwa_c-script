using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076EF RID: 30447
	public static class ISceneUiSubtitleScatterVerify
	{
		// Token: 0x060356C2 RID: 218818 RVA: 0x0072A1EC File Offset: 0x007283EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleScatterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleScatterVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitlePositionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneUiSubtitleScatterVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneUiSubtitleScatterVerify.<>O.<1>__Verify = new VerifyTableAction(ISceneUiSubtitleLocalizationConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086B4 RID: 34484
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AAB RID: 84651
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014AAC RID: 84652
			public static VerifyTableAction <1>__Verify;
		}
	}
}
