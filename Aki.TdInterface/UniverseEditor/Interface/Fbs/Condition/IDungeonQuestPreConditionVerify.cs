using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BFD RID: 19453
	public static class IDungeonQuestPreConditionVerify
	{
		// Token: 0x0601ECDA RID: 126170 RVA: 0x004507F4 File Offset: 0x0044E9F4
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

		// Token: 0x02007A5C RID: 31324
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013424 RID: 78884
			public static VerifyTableAction <0>__Verify;
		}
	}
}
