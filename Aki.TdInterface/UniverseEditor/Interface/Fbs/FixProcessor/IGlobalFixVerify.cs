using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC4 RID: 19396
	public static class IGlobalFixVerify
	{
		// Token: 0x0601D9C9 RID: 121289 RVA: 0x00428230 File Offset: 0x00426430
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGlobalFixVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGlobalFixVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 14;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGlobalFixVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IGlobalFixVerify.<>O.<1>__Verify = new VerifyTableAction(IGlobalFixActionsVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008234 RID: 33332
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143FE RID: 82942
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040143FF RID: 82943
			public static VerifyTableAction <1>__Verify;
		}
	}
}
