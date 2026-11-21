using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBA RID: 23482
	public static class INpcBumpShowVerify
	{
		// Token: 0x06026B6C RID: 158572 RVA: 0x0054C979 File Offset: 0x0054AB79
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcBumpShowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcBumpShowVerify.<>O.<0>__Verify = new VerifyTableAction(INpcPerformBubbleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200840A RID: 33802
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146CE RID: 83662
			public static VerifyTableAction <0>__Verify;
		}
	}
}
