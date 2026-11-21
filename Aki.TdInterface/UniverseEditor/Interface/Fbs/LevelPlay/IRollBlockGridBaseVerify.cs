using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C7 RID: 18887
	public static class IRollBlockGridBaseVerify
	{
		// Token: 0x0601C3C7 RID: 115655 RVA: 0x003FCBAC File Offset: 0x003FADAC
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

		// Token: 0x02008201 RID: 33281
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143BA RID: 82874
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
