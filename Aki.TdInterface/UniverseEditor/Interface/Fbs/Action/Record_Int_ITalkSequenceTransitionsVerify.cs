using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007624 RID: 30244
	public static class Record_Int_ITalkSequenceTransitionsVerify
	{
		// Token: 0x0603716B RID: 225643 RVA: 0x00778B08 File Offset: 0x00776D08
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

		// Token: 0x02007EDC RID: 32476
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C2E RID: 80942
			public static VerifyTableAction <0>__Verify;
		}
	}
}
