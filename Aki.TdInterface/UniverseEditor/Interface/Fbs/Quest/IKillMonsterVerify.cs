using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004309 RID: 17161
	public static class IKillMonsterVerify
	{
		// Token: 0x0601821D RID: 98845 RVA: 0x00371804 File Offset: 0x0036FA04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IKillMonsterVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IKillMonsterVerify.<>O.<0>__Verify = new VerifyTableAction(IKillSingleMonsterVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008143 RID: 33091
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401421C RID: 82460
			public static VerifyTableAction <0>__Verify;
		}
	}
}
