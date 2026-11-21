using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049D3 RID: 18899
	public static class IRollBlockGridFallFloorVerify
	{
		// Token: 0x0601C47D RID: 115837 RVA: 0x003FE958 File Offset: 0x003FCB58
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

		// Token: 0x02008204 RID: 33284
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143BD RID: 82877
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
