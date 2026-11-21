using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DA8 RID: 32168
	public static class IVisualNovelPerformanceLeaveBlackScreenVerify
	{
		// Token: 0x0603A1A3 RID: 237987 RVA: 0x007D5204 File Offset: 0x007D3404
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceLeaveBlackScreenVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceLeaveBlackScreenVerify.<>O.<0>__Verify = new VerifyUnionAction(TEaseCurveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200876B RID: 34667
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CFA RID: 85242
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
