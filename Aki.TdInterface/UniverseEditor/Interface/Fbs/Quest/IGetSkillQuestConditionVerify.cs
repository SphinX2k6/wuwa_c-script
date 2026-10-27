using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E7D RID: 15997
	public static class IGetSkillQuestConditionVerify
	{
		// Token: 0x060168B4 RID: 92340 RVA: 0x00341ED4 File Offset: 0x003400D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGetSkillQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGetSkillQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078EE RID: 30958
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A8 RID: 78248
			public static VerifyTableAction <0>__Verify;
		}
	}
}
