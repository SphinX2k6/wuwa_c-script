using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D7 RID: 22487
	public static class IRaceStrategyVerify
	{
		// Token: 0x06025C2B RID: 154667 RVA: 0x00535078 File Offset: 0x00533278
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

		// Token: 0x02007BF4 RID: 31732
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136BF RID: 79551
			public static VerifyTableAction <0>__Verify;
		}
	}
}
