using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200456E RID: 17774
	public static class IRollBlockGridFloorVerify
	{
		// Token: 0x0601ACDA RID: 109786 RVA: 0x003D2F64 File Offset: 0x003D1164
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

		// Token: 0x020079BC RID: 31164
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013357 RID: 78679
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
