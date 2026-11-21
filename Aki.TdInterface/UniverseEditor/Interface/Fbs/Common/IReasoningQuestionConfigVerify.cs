using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200648D RID: 25741
	public static class IReasoningQuestionConfigVerify
	{
		// Token: 0x0602BBD8 RID: 179160 RVA: 0x005F3628 File Offset: 0x005F1828
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReasoningQuestionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReasoningQuestionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IReasoningResultConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008525 RID: 34085
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014888 RID: 84104
			public static VerifyTableAction <0>__Verify;
		}
	}
}
