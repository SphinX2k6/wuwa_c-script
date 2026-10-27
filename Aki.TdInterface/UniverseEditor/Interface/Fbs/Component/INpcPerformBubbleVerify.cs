using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005631 RID: 22065
	public static class INpcPerformBubbleVerify
	{
		// Token: 0x06024A2E RID: 150062 RVA: 0x0050DCF8 File Offset: 0x0050BEF8
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

		// Token: 0x02007BAC RID: 31660
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013643 RID: 79427
			public static VerifyTableAction <0>__Verify;
		}
	}
}
