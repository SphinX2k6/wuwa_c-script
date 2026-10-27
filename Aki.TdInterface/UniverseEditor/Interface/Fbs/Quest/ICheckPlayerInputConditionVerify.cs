using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D60 RID: 15712
	public static class ICheckPlayerInputConditionVerify
	{
		// Token: 0x06015BD0 RID: 89040 RVA: 0x00322A5C File Offset: 0x00320C5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerInputConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerInputConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICheckPlayerInputConditionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICheckPlayerInputConditionVerify.<>O.<1>__Verify = new VerifyTableAction(ICheckPlayerPressButtonVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078BC RID: 30908
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013135 RID: 78133
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013136 RID: 78134
			public static VerifyTableAction <1>__Verify;
		}
	}
}
