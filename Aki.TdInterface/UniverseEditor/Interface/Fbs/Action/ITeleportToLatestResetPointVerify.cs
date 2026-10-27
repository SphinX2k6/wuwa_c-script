using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200738D RID: 29581
	public static class ITeleportToLatestResetPointVerify
	{
		// Token: 0x06035B1E RID: 219934 RVA: 0x0074F79D File Offset: 0x0074D99D
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

		// Token: 0x02007E9B RID: 32411
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BD3 RID: 80851
			public static VerifyTableAction <0>__Verify;
		}
	}
}
