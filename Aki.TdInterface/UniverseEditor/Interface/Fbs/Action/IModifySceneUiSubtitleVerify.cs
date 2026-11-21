using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007206 RID: 29190
	public static class IModifySceneUiSubtitleVerify
	{
		// Token: 0x06032C79 RID: 207993 RVA: 0x006DBC00 File Offset: 0x006D9E00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifySceneUiSubtitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifySceneUiSubtitleVerify.<>O.<0>__Verify = new VerifyUnionAction(TSceneUiSubtitleOperationVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008633 RID: 34355
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A06 RID: 84486
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
