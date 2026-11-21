using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA2 RID: 32162
	public static class IVisualNovelPerformanceEnterBlackScreenVerify
	{
		// Token: 0x0603A153 RID: 237907 RVA: 0x007D4728 File Offset: 0x007D2928
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceEnterBlackScreenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceEnterBlackScreenVerify.<>O.<0>__Verify = new VerifyUnionAction(TEaseCurveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008769 RID: 34665
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CF8 RID: 85240
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
