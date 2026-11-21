using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004724 RID: 18212
	public static class TCsvTetrisBoardDataVerify
	{
		// Token: 0x0601AD2C RID: 109868 RVA: 0x003CEFB8 File Offset: 0x003CD1B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvTetrisBoardDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvTetrisBoardDataVerify.<>O.<0>__Verify = new VerifyTableAction(ITetrisBoardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081CD RID: 33229
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014368 RID: 82792
			public static VerifyTableAction <0>__Verify;
		}
	}
}
