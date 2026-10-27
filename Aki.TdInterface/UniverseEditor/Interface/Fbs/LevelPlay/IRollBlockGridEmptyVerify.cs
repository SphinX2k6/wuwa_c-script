using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004568 RID: 17768
	public static class IRollBlockGridEmptyVerify
	{
		// Token: 0x0601AC76 RID: 109686 RVA: 0x003D1E14 File Offset: 0x003D0014
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

		// Token: 0x020079BA RID: 31162
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013355 RID: 78677
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
