using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A00 RID: 18944
	public static class IRollBlockItemBreakableObstacleVerify
	{
		// Token: 0x0601C679 RID: 116345 RVA: 0x00403250 File Offset: 0x00401450
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

		// Token: 0x0200820B RID: 33291
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143C4 RID: 82884
			public static VerifyTableAction <0>__Verify;
		}
	}
}
