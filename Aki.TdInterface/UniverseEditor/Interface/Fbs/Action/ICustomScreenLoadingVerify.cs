using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B6E RID: 27502
	public static class ICustomScreenLoadingVerify
	{
		// Token: 0x0602F546 RID: 193862 RVA: 0x006759DC File Offset: 0x00673BDC
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

		// Token: 0x020085AC RID: 34220
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014952 RID: 84306
			public static VerifyTableAction <0>__Verify;
		}
	}
}
