using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D9 RID: 18905
	public static class IRollBlockGridGoalVerify
	{
		// Token: 0x0601C4E1 RID: 115937 RVA: 0x003FFAA8 File Offset: 0x003FDCA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridGoalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridGoalVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008206 RID: 33286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143BF RID: 82879
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
