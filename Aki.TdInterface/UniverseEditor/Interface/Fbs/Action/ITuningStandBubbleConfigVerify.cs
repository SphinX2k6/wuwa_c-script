using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007498 RID: 29848
	public static class ITuningStandBubbleConfigVerify
	{
		// Token: 0x0603641B RID: 222235 RVA: 0x007602F8 File Offset: 0x0075E4F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITuningStandBubbleConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITuningStandBubbleConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EB6 RID: 32438
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BFD RID: 80893
			public static VerifyTableAction <0>__Verify;
		}
	}
}
