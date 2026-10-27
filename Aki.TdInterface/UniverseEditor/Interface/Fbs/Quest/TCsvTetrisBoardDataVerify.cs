using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C8 RID: 17096
	public static class TCsvTetrisBoardDataVerify
	{
		// Token: 0x060195C0 RID: 103872 RVA: 0x003A38E0 File Offset: 0x003A1AE0
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

		// Token: 0x02007984 RID: 31108
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013301 RID: 78593
			public static VerifyTableAction <0>__Verify;
		}
	}
}
