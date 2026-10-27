using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D40 RID: 27968
	public static class IPlaySequenceDataVerify
	{
		// Token: 0x06031606 RID: 202246 RVA: 0x006B24F8 File Offset: 0x006B06F8
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

		// Token: 0x02007DFC RID: 32252
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139B6 RID: 80310
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139B7 RID: 80311
			public static VerifyTableAction <1>__Verify;
		}
	}
}
