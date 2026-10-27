using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045A4 RID: 17828
	public static class IRollBlockLevelConfigVerify
	{
		// Token: 0x0601AF32 RID: 110386 RVA: 0x003D8128 File Offset: 0x003D6328
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockLevelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockLevelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRollBlockBoardConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 12, 1UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C3 RID: 31171
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401335E RID: 78686
			public static VerifyTableAction <0>__Verify;
		}
	}
}
