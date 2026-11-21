using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050EA RID: 20714
	public static class IDungeonQuestPreConditionVerify
	{
		// Token: 0x060208C0 RID: 133312 RVA: 0x00483E5C File Offset: 0x0048205C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDungeonQuestPreConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDungeonQuestPreConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IQuestPreConditionDungeonIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082AE RID: 33454
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014494 RID: 83092
			public static VerifyTableAction <0>__Verify;
		}
	}
}
