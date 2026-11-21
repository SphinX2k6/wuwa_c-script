using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076D4 RID: 30420
	public static class ISceneUiSubtitleConfigVerify
	{
		// Token: 0x060355F0 RID: 218608 RVA: 0x007289B0 File Offset: 0x00726BB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitlePositionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneUiSubtitleConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneUiSubtitleConfigVerify.<>O.<1>__Verify = new VerifyTableAction(ISceneUiSubtitleLocalizationConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086B0 RID: 34480
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA6 RID: 84646
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014AA7 RID: 84647
			public static VerifyTableAction <1>__Verify;
		}
	}
}
