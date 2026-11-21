using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E14 RID: 24084
	public static class IReboundComponentVerify
	{
		// Token: 0x06028384 RID: 164740 RVA: 0x0058011C File Offset: 0x0057E31C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReboundComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReboundComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IForwardFrontReboundVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200846E RID: 33902
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014771 RID: 83825
			public static VerifyTableAction <0>__Verify;
		}
	}
}
