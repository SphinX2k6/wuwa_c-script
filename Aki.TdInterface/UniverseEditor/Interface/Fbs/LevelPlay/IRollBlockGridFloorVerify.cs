using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D6 RID: 18902
	public static class IRollBlockGridFloorVerify
	{
		// Token: 0x0601C4AF RID: 115887 RVA: 0x003FF200 File Offset: 0x003FD400
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridFloorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridFloorVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008205 RID: 33285
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143BE RID: 82878
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
