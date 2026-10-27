using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DA5 RID: 15781
	public static class ICompareVarConditionInQuestFailedVerify
	{
		// Token: 0x06015F03 RID: 89859 RVA: 0x0032AF40 File Offset: 0x00329140
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

		// Token: 0x020078C6 RID: 30918
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401314D RID: 78157
			public static VerifyTableAction <0>__Verify;
		}
	}
}
