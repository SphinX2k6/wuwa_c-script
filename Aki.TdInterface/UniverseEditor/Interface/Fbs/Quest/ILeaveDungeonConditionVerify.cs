using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF8 RID: 16120
	public static class ILeaveDungeonConditionVerify
	{
		// Token: 0x06016CF9 RID: 93433 RVA: 0x0034A48C File Offset: 0x0034868C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILeaveDungeonConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILeaveDungeonConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007900 RID: 30976
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131C0 RID: 78272
			public static VerifyTableAction <0>__Verify;
		}
	}
}
