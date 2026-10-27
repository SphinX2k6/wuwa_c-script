using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F18 RID: 20248
	public static class IBehaviorFlowComponentVerify
	{
		// Token: 0x06020049 RID: 131145 RVA: 0x00474A84 File Offset: 0x00472C84
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBehaviorFlowComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBehaviorFlowComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A90 RID: 31376
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401346F RID: 78959
			public static VerifyTableAction <0>__Verify;
		}
	}
}
