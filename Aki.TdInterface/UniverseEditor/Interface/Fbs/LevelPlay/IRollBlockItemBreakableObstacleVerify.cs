using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004598 RID: 17816
	public static class IRollBlockItemBreakableObstacleVerify
	{
		// Token: 0x0601AEA4 RID: 110244 RVA: 0x003D6FB4 File Offset: 0x003D51B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockItemBreakableObstacleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockItemBreakableObstacleVerify.<>O.<0>__Verify = new VerifyTableAction(IRollBlockPathVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079C2 RID: 31170
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401335D RID: 78685
			public static VerifyTableAction <0>__Verify;
		}
	}
}
