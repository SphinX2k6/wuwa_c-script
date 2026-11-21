using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200750F RID: 29967
	public static class IPreloadFlowsVerify
	{
		// Token: 0x060348D6 RID: 215254 RVA: 0x00712D24 File Offset: 0x00710F24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreloadFlowsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreloadFlowsVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008691 RID: 34449
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A84 RID: 84612
			public static VerifyTableAction <0>__Verify;
		}
	}
}
