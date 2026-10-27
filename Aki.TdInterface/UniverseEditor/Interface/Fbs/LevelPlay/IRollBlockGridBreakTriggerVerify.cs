using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004565 RID: 17765
	public static class IRollBlockGridBreakTriggerVerify
	{
		// Token: 0x0601AC44 RID: 109636 RVA: 0x003D155C File Offset: 0x003CF75C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridBreakTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridBreakTriggerVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B9 RID: 31161
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013354 RID: 78676
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
