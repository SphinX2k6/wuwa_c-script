using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200538D RID: 21389
	public static class IAiGearStrategyVerify
	{
		// Token: 0x060215AE RID: 136622 RVA: 0x0049A5C4 File Offset: 0x004987C4
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

		// Token: 0x020082C9 RID: 33481
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144B7 RID: 83127
			public static VerifyTableAction <0>__Verify;
		}
	}
}
