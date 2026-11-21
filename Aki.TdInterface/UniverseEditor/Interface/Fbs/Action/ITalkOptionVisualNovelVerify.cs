using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B2F RID: 31535
	public static class ITalkOptionVisualNovelVerify
	{
		// Token: 0x06038CB2 RID: 232626 RVA: 0x007AE664 File Offset: 0x007AC864
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkOptionVisualNovelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkOptionVisualNovelVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkOptionVisualNovelDoubleConfirmVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008730 RID: 34608
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CA8 RID: 85160
			public static VerifyTableAction <0>__Verify;
		}
	}
}
