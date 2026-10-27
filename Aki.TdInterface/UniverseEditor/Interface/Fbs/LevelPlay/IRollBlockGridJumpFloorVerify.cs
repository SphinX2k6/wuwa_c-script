using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004574 RID: 17780
	public static class IRollBlockGridJumpFloorVerify
	{
		// Token: 0x0601AD42 RID: 109890 RVA: 0x003D4144 File Offset: 0x003D2344
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridJumpFloorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridJumpFloorVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079BE RID: 31166
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013359 RID: 78681
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
