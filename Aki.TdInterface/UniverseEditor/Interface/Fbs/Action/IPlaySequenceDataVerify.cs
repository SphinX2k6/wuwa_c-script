using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BB RID: 29883
	public static class IPlaySequenceDataVerify
	{
		// Token: 0x06034602 RID: 214530 RVA: 0x0070DBE0 File Offset: 0x0070BDE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlaySequenceDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlaySequenceDataVerify.<>O.<0>__Verify = new VerifyTableAction(ISequenceFrameEventVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					short offsetId2 = 16;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPlaySequenceDataVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPlaySequenceDataVerify.<>O.<1>__Verify = new VerifyTableAction(ISetBlendAnimVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008688 RID: 34440
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A7A RID: 84602
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014A7B RID: 84603
			public static VerifyTableAction <1>__Verify;
		}
	}
}
