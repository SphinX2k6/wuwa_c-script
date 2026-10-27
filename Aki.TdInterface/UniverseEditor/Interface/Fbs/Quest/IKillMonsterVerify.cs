using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ECB RID: 16075
	public static class IKillMonsterVerify
	{
		// Token: 0x06016BC6 RID: 93126 RVA: 0x00348638 File Offset: 0x00346838
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

		// Token: 0x020078FD RID: 30973
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131BD RID: 78269
			public static VerifyTableAction <0>__Verify;
		}
	}
}
