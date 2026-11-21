using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1C RID: 27164
	public static class IClientEventPianoUpdateSubtitleVerify
	{
		// Token: 0x0602E9A0 RID: 190880 RVA: 0x0065AD0C File Offset: 0x00658F0C
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

		// Token: 0x0200858F RID: 34191
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014930 RID: 84272
			public static VerifyTableAction <0>__Verify;
		}
	}
}
