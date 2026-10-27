using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200580D RID: 22541
	public static class IReboundComponentVerify
	{
		// Token: 0x06025E64 RID: 155236 RVA: 0x00539F90 File Offset: 0x00538190
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

		// Token: 0x02007C00 RID: 31744
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D1 RID: 79569
			public static VerifyTableAction <0>__Verify;
		}
	}
}
