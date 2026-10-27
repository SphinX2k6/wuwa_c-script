using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063AB RID: 25515
	public static class IClientEventPianoUpdateSubtitleVerify
	{
		// Token: 0x0602C23E RID: 180798 RVA: 0x0060FCD4 File Offset: 0x0060DED4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IClientEventPianoUpdateSubtitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IClientEventPianoUpdateSubtitleVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D1B RID: 32027
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013886 RID: 80006
			public static VerifyTableAction <0>__Verify;
		}
	}
}
