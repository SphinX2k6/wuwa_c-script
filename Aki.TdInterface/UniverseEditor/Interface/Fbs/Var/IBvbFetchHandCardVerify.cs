using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E31 RID: 15921
	public static class IBvbFetchHandCardVerify
	{
		// Token: 0x060156DB RID: 87771 RVA: 0x00317E24 File Offset: 0x00316024
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBvbFetchHandCardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbFetchHandCardVerify.<>O.<0>__Verify = new VerifyTableAction(IBvbCardFilterGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B2 RID: 32946
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014131 RID: 82225
			public static VerifyTableAction <0>__Verify;
		}
	}
}
