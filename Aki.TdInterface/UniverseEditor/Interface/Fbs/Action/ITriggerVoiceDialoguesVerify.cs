using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007492 RID: 29842
	public static class ITriggerVoiceDialoguesVerify
	{
		// Token: 0x060363C5 RID: 222149 RVA: 0x0075F738 File Offset: 0x0075D938
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

		// Token: 0x02007EB4 RID: 32436
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BFA RID: 80890
			public static VerifyTableAction <0>__Verify;
		}
	}
}
