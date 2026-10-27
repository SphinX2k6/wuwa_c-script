using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F2 RID: 17906
	public static class TCsvTrapDefenseDataVerify
	{
		// Token: 0x0601B1FA RID: 111098 RVA: 0x003DD878 File Offset: 0x003DBA78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvTrapDefenseDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvTrapDefenseDataVerify.<>O.<0>__Verify = new VerifyTableAction(ITrapDefenseBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079CB RID: 31179
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013367 RID: 78695
			public static VerifyTableAction <0>__Verify;
		}
	}
}
