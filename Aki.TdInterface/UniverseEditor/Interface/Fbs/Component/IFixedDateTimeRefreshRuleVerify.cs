using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200526F RID: 21103
	public static class IFixedDateTimeRefreshRuleVerify
	{
		// Token: 0x06022572 RID: 140658 RVA: 0x004C2908 File Offset: 0x004C0B08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedDateTimeRefreshRuleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedDateTimeRefreshRuleVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B22 RID: 31522
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013559 RID: 79193
			public static VerifyTableAction <0>__Verify;
		}
	}
}
