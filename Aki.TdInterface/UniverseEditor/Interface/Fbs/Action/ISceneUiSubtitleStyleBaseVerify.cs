using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F2 RID: 30450
	public static class ISceneUiSubtitleStyleBaseVerify
	{
		// Token: 0x060356EC RID: 218860 RVA: 0x0072A834 File Offset: 0x00728A34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISceneUiSubtitleStyleBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneUiSubtitleStyleBaseVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitlePositionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short offsetId = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneUiSubtitleStyleBaseVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneUiSubtitleStyleBaseVerify.<>O.<1>__Verify = new VerifyTableAction(ISceneUiSubtitleLocalizationConfigVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020086B5 RID: 34485
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AAD RID: 84653
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014AAE RID: 84654
			public static VerifyTableAction <1>__Verify;
		}
	}
}
