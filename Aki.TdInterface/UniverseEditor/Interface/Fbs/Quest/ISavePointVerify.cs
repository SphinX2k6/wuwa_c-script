using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004105 RID: 16645
	public static class ISavePointVerify
	{
		// Token: 0x06018450 RID: 99408 RVA: 0x0037E30C File Offset: 0x0037C50C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISavePointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISavePointVerify.<>O.<0>__Verify = new VerifyTableAction(IPositionRollbackConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007950 RID: 31056
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013273 RID: 78451
			public static VerifyTableAction <0>__Verify;
		}
	}
}
