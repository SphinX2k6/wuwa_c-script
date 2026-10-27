using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A8F RID: 19087
	public static class ICheckIsGramophonePlayingMusicVerify
	{
		// Token: 0x0601DEFB RID: 122619 RVA: 0x00434374 File Offset: 0x00432574
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

		// Token: 0x02007A38 RID: 31288
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133FC RID: 78844
			public static VerifyTableAction <0>__Verify;
		}
	}
}
