using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006500 RID: 25856
	public static class ICustomScreenLoadingVerify
	{
		// Token: 0x0602CDB0 RID: 183728 RVA: 0x0062973C File Offset: 0x0062793C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICustomScreenLoadingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICustomScreenLoadingVerify.<>O.<0>__Verify = new VerifyTableAction(ICustomScreenLoadingCyberpunkVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D37 RID: 32055
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138A7 RID: 80039
			public static VerifyTableAction <0>__Verify;
		}
	}
}
