using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D0 RID: 18896
	public static class IRollBlockGridEmptyVerify
	{
		// Token: 0x0601C44B RID: 115787 RVA: 0x003FE0B0 File Offset: 0x003FC2B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridEmptyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridEmptyVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008203 RID: 33283
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143BC RID: 82876
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
