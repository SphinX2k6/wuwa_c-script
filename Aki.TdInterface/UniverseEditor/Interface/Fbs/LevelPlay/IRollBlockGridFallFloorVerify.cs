using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200456B RID: 17771
	public static class IRollBlockGridFallFloorVerify
	{
		// Token: 0x0601ACA8 RID: 109736 RVA: 0x003D26BC File Offset: 0x003D08BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridFallFloorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridFallFloorVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079BB RID: 31163
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013356 RID: 78678
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
