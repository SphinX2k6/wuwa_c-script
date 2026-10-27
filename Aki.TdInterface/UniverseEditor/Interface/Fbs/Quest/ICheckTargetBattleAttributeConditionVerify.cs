using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D75 RID: 15733
	public static class ICheckTargetBattleAttributeConditionVerify
	{
		// Token: 0x06015C86 RID: 89222 RVA: 0x00324034 File Offset: 0x00322234
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckTargetBattleAttributeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckTargetBattleAttributeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078BE RID: 30910
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013139 RID: 78137
			public static VerifyTableAction <0>__Verify;
		}
	}
}
