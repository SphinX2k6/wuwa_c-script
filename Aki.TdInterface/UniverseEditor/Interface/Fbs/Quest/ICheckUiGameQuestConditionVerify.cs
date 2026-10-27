using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D87 RID: 15751
	public static class ICheckUiGameQuestConditionVerify
	{
		// Token: 0x06015D16 RID: 89366 RVA: 0x00325914 File Offset: 0x00323B14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckUiGameQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckUiGameQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078C0 RID: 30912
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401313C RID: 78140
			public static VerifyTableAction <0>__Verify;
		}
	}
}
