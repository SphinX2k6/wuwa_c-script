using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200455F RID: 17759
	public static class IRollBlockGridBaseVerify
	{
		// Token: 0x0601ABF2 RID: 109554 RVA: 0x003D0910 File Offset: 0x003CEB10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRollBlockGridBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGridBaseVerify.<>O.<0>__Verify = new VerifyUnionAction(TRollBlockVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B8 RID: 31160
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013353 RID: 78675
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
