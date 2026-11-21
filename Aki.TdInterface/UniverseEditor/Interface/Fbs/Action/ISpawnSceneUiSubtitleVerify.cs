using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007940 RID: 31040
	public static class ISpawnSceneUiSubtitleVerify
	{
		// Token: 0x06036AC0 RID: 223936 RVA: 0x00750DAC File Offset: 0x0074EFAC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISpawnSceneUiSubtitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpawnSceneUiSubtitleVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitleStyleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 12;
					short valueVOffset2 = 14;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISpawnSceneUiSubtitleVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISpawnSceneUiSubtitleVerify.<>O.<1>__Verify = new VerifyUnionAction(TSceneUiSubtitleTextVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008701 RID: 34561
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B1F RID: 84767
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014B20 RID: 84768
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
