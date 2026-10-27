using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075AF RID: 30127
	public static class IVisualNovelPerformanceLeaveBlackScreenVerify
	{
		// Token: 0x06036D75 RID: 224629 RVA: 0x00771C84 File Offset: 0x0076FE84
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

		// Token: 0x02007ED1 RID: 32465
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C20 RID: 80928
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
