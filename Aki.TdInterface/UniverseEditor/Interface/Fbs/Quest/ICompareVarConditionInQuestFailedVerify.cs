using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041BC RID: 16828
	public static class ICompareVarConditionInQuestFailedVerify
	{
		// Token: 0x0601743B RID: 95291 RVA: 0x0035226C File Offset: 0x0035046C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICompareVarConditionInQuestFailedVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareVarConditionInQuestFailedVerify.<>O.<0>__Verify = new VerifyTableAction(ICompareVarInChildQuestVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200810A RID: 33034
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040141A9 RID: 82345
			public static VerifyTableAction <0>__Verify;
		}
	}
}
