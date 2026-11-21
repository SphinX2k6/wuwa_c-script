using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DDE RID: 24030
	public static class IRaceStrategyVerify
	{
		// Token: 0x0602814B RID: 164171 RVA: 0x0057B204 File Offset: 0x00579404
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRaceStrategyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRaceStrategyVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008462 RID: 33890
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401475F RID: 83807
			public static VerifyTableAction <0>__Verify;
		}
	}
}
