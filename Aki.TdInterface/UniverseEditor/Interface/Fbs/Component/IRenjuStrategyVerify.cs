using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585D RID: 22621
	public static class IRenjuStrategyVerify
	{
		// Token: 0x06026160 RID: 156000 RVA: 0x00540204 File Offset: 0x0053E404
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRenjuStrategyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenjuStrategyVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C0C RID: 31756
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136E2 RID: 79586
			public static VerifyTableAction <0>__Verify;
		}
	}
}
