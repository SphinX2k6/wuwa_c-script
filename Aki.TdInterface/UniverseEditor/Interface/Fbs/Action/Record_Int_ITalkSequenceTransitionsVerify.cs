using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E32 RID: 32306
	public static class Record_Int_ITalkSequenceTransitionsVerify
	{
		// Token: 0x0603A610 RID: 239120 RVA: 0x007DCC04 File Offset: 0x007DAE04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_Int_ITalkSequenceTransitionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_Int_ITalkSequenceTransitionsVerify.<>O.<0>__Verify = new VerifyTableAction(ITalkSequenceTransitionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008778 RID: 34680
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D0A RID: 85258
			public static VerifyTableAction <0>__Verify;
		}
	}
}
