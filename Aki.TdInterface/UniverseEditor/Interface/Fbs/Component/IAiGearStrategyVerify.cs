using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E7C RID: 20092
	public static class IAiGearStrategyVerify
	{
		// Token: 0x0601F963 RID: 129379 RVA: 0x004665AC File Offset: 0x004647AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAiGearStrategyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAiGearStrategyVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A77 RID: 31351
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013447 RID: 78919
			public static VerifyTableAction <0>__Verify;
		}
	}
}
