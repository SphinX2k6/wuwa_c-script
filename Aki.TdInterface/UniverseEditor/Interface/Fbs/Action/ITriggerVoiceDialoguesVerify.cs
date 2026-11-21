using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C85 RID: 31877
	public static class ITriggerVoiceDialoguesVerify
	{
		// Token: 0x060397B2 RID: 235442 RVA: 0x007C24F4 File Offset: 0x007C06F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITriggerVoiceDialoguesVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITriggerVoiceDialoguesVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200874E RID: 34638
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CD4 RID: 85204
			public static VerifyTableAction <0>__Verify;
		}
	}
}
