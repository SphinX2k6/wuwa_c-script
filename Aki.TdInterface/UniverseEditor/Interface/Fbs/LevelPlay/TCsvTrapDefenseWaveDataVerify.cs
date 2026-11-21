using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A60 RID: 19040
	public static class TCsvTrapDefenseWaveDataVerify
	{
		// Token: 0x0601CA07 RID: 117255 RVA: 0x0040A26C File Offset: 0x0040846C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvTrapDefenseWaveDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvTrapDefenseWaveDataVerify.<>O.<0>__Verify = new VerifyTableAction(ITrapDefenseSpawnMonsterVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008216 RID: 33302
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D0 RID: 82896
			public static VerifyTableAction <0>__Verify;
		}
	}
}
