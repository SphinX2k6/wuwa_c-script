using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x0200435F RID: 17247
	public static class IPerformerAiConditionDecoratorVerify
	{
		// Token: 0x06019945 RID: 104773 RVA: 0x003A956C File Offset: 0x003A776C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPerformerAiConditionDecoratorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerAiConditionDecoratorVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007987 RID: 31111
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013305 RID: 78597
			public static VerifyTableAction <0>__Verify;
		}
	}
}
