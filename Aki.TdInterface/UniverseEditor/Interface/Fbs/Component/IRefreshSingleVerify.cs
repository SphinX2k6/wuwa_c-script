using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E41 RID: 24129
	public static class IRefreshSingleVerify
	{
		// Token: 0x060284F6 RID: 165110 RVA: 0x00582C54 File Offset: 0x00580E54
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

		// Token: 0x02008473 RID: 33907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014778 RID: 83832
			public static VerifyTableAction <0>__Verify;
		}
	}
}
