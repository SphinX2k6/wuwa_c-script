using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D51 RID: 15697
	public static class ICheckLevelPlayQuestConditionVerify
	{
		// Token: 0x06015B60 RID: 88928 RVA: 0x00321D8C File Offset: 0x0031FF8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckLevelPlayQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckLevelPlayQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078B9 RID: 30905
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013132 RID: 78130
			public static VerifyTableAction <0>__Verify;
		}
	}
}
