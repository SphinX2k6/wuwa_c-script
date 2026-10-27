using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F8 RID: 17912
	public static class TCsvTrapDefenseWaveDataVerify
	{
		// Token: 0x0601B232 RID: 111154 RVA: 0x003DDFD0 File Offset: 0x003DC1D0
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

		// Token: 0x020079CD RID: 31181
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013369 RID: 78697
			public static VerifyTableAction <0>__Verify;
		}
	}
}
