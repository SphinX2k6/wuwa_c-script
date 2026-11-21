using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F55 RID: 20309
	public static class ICheckIsGramophonePlayingMusicVerify
	{
		// Token: 0x0601F99E RID: 129438 RVA: 0x00465500 File Offset: 0x00463700
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckIsGramophonePlayingMusicVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckIsGramophonePlayingMusicVerify.<>O.<0>__Verify = new VerifyTableAction(IGramophoneCheckConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008288 RID: 33416
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401446A RID: 83050
			public static VerifyTableAction <0>__Verify;
		}
	}
}
