using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ADE RID: 31454
	public static class ITalkItemStyleSceneUiSubtitleVerify
	{
		// Token: 0x0603832F RID: 230191 RVA: 0x00790148 File Offset: 0x0078E348
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITalkItemStyleSceneUiSubtitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkItemStyleSceneUiSubtitleVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitleStyleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008726 RID: 34598
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014C26 RID: 85030
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
