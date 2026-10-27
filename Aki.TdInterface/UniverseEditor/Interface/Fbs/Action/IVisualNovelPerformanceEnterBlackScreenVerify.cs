using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075A9 RID: 30121
	public static class IVisualNovelPerformanceEnterBlackScreenVerify
	{
		// Token: 0x06036D25 RID: 224549 RVA: 0x007711A8 File Offset: 0x0076F3A8
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

		// Token: 0x02007ECF RID: 32463
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C1E RID: 80926
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
