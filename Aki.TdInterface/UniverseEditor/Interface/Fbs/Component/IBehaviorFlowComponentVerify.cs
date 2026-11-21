using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544A RID: 21578
	public static class IBehaviorFlowComponentVerify
	{
		// Token: 0x06021DB9 RID: 138681 RVA: 0x004AAE18 File Offset: 0x004A9018
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

		// Token: 0x020082E7 RID: 33511
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144E6 RID: 83174
			public static VerifyTableAction <0>__Verify;
		}
	}
}
