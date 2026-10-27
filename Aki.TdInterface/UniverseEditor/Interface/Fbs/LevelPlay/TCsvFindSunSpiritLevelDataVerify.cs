using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045EF RID: 17903
	public static class TCsvFindSunSpiritLevelDataVerify
	{
		// Token: 0x0601B1DE RID: 111070 RVA: 0x003DD4CC File Offset: 0x003DB6CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = TCsvFindSunSpiritLevelDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (TCsvFindSunSpiritLevelDataVerify.<>O.<0>__Verify = new VerifyTableAction(IFindSunSpiritLevelConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079CA RID: 31178
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013366 RID: 78694
			public static VerifyTableAction <0>__Verify;
		}
	}
}
