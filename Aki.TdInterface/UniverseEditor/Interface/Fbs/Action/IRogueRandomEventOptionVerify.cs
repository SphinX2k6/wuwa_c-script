using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EE7 RID: 28391
	public static class IRogueRandomEventOptionVerify
	{
		// Token: 0x060322C4 RID: 205508 RVA: 0x006C7DEC File Offset: 0x006C5FEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRogueRandomEventOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRogueRandomEventOptionVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E1B RID: 32283
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139D7 RID: 80343
			public static VerifyTableAction <0>__Verify;
		}
	}
}
