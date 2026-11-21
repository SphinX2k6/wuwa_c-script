using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB1 RID: 32177
	public static class IVisualNovelPerformancePlayScreenEffectVerify
	{
		// Token: 0x0603A21E RID: 238110 RVA: 0x007D647C File Offset: 0x007D467C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVisualNovelPerformancePlayScreenEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformancePlayScreenEffectVerify.<>O.<0>__Verify = new VerifyUnionAction(TVisualNovelPlayScreenEffectConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200876E RID: 34670
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D00 RID: 85248
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
