using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DBD RID: 32189
	public static class IVisualNovelPerformanceStopScreenEffectVerify
	{
		// Token: 0x0603A2AC RID: 238252 RVA: 0x007D7574 File Offset: 0x007D5774
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceStopScreenEffectVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceStopScreenEffectVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelStopScreenEffectPersistentVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008770 RID: 34672
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D02 RID: 85250
			public static VerifyTableAction <0>__Verify;
		}
	}
}
