using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583A RID: 22586
	public static class IRefreshSingleVerify
	{
		// Token: 0x06025FD6 RID: 155606 RVA: 0x0053CAC8 File Offset: 0x0053ACC8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRefreshSingleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRefreshSingleVerify.<>O.<0>__Verify = new VerifyTableAction(ITempleGuidVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C05 RID: 31749
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136D8 RID: 79576
			public static VerifyTableAction <0>__Verify;
		}
	}
}
