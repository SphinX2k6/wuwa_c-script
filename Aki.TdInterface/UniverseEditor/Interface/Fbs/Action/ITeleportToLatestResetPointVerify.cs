using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B74 RID: 31604
	public static class ITeleportToLatestResetPointVerify
	{
		// Token: 0x06038EB9 RID: 233145 RVA: 0x007B1CDD File Offset: 0x007AFEDD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportToLatestResetPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportToLatestResetPointVerify.<>O.<0>__Verify = new VerifyTableAction(ITeleportToLatestResetPointDirectlyVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008734 RID: 34612
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CAC RID: 85164
			public static VerifyTableAction <0>__Verify;
		}
	}
}
