using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049DC RID: 18908
	public static class IRollBlockGridJumpFloorVerify
	{
		// Token: 0x0601C517 RID: 115991 RVA: 0x004003E0 File Offset: 0x003FE5E0
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

		// Token: 0x02008207 RID: 33287
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143C0 RID: 82880
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
