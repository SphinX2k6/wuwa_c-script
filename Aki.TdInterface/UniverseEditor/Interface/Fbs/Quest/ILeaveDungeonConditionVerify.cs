using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004336 RID: 17206
	public static class ILeaveDungeonConditionVerify
	{
		// Token: 0x06018350 RID: 99152 RVA: 0x00373658 File Offset: 0x00371858
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

		// Token: 0x02008146 RID: 33094
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401421F RID: 82463
			public static VerifyTableAction <0>__Verify;
		}
	}
}
