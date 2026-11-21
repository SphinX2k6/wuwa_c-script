using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A5A RID: 19034
	public static class TCsvTrapDefenseDataVerify
	{
		// Token: 0x0601C9CF RID: 117199 RVA: 0x00409B14 File Offset: 0x00407D14
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

		// Token: 0x02008214 RID: 33300
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143CE RID: 82894
			public static VerifyTableAction <0>__Verify;
		}
	}
}
