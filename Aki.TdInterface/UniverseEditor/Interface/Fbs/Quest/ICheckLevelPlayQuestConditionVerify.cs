using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004168 RID: 16744
	public static class ICheckLevelPlayQuestConditionVerify
	{
		// Token: 0x06017098 RID: 94360 RVA: 0x00349004 File Offset: 0x00347204
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

		// Token: 0x020080FD RID: 33021
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401418E RID: 82318
			public static VerifyTableAction <0>__Verify;
		}
	}
}
