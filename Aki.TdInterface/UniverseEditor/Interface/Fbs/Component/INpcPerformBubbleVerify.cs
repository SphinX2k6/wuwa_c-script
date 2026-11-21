using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCF RID: 23503
	public static class INpcPerformBubbleVerify
	{
		// Token: 0x06026C41 RID: 158785 RVA: 0x0054E3B8 File Offset: 0x0054C5B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcPerformBubbleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcPerformBubbleVerify.<>O.<0>__Verify = new VerifyTableAction(IBubbleIndexVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200840E RID: 33806
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146D2 RID: 83666
			public static VerifyTableAction <0>__Verify;
		}
	}
}
