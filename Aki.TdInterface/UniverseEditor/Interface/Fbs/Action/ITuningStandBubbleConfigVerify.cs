using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C8B RID: 31883
	public static class ITuningStandBubbleConfigVerify
	{
		// Token: 0x06039808 RID: 235528 RVA: 0x007C30B4 File Offset: 0x007C12B4
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

		// Token: 0x02008750 RID: 34640
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD7 RID: 85207
			public static VerifyTableAction <0>__Verify;
		}
	}
}
