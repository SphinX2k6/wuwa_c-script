using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E4D RID: 24141
	public static class IReasoningQuestionConfigVerify
	{
		// Token: 0x0602953C RID: 169276 RVA: 0x005AA780 File Offset: 0x005A8980
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

		// Token: 0x02007CB4 RID: 31924
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E2 RID: 79842
			public static VerifyTableAction <0>__Verify;
		}
	}
}
