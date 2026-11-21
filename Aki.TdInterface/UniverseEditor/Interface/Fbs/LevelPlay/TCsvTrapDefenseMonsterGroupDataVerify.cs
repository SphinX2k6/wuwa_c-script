using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A5D RID: 19037
	public static class TCsvTrapDefenseMonsterGroupDataVerify
	{
		// Token: 0x0601C9EB RID: 117227 RVA: 0x00409EC0 File Offset: 0x004080C0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvTrapDefenseMonsterGroupDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvTrapDefenseMonsterGroupDataVerify.<>O.<0>__Verify = new VerifyTableAction(ITrapDefenseMonsterGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008215 RID: 33301
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143CF RID: 82895
			public static VerifyTableAction <0>__Verify;
		}
	}
}
