using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047C1 RID: 18369
	public static class IPerformerAiConditionDecoratorVerify
	{
		// Token: 0x0601B0D3 RID: 110803 RVA: 0x003D4F94 File Offset: 0x003D3194
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

		// Token: 0x020081D0 RID: 33232
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401436C RID: 82796
			public static VerifyTableAction <0>__Verify;
		}
	}
}
