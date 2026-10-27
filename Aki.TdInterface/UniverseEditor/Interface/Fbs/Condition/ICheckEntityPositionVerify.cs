using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A11 RID: 18961
	public static class ICheckEntityPositionVerify
	{
		// Token: 0x0601DAA0 RID: 121504 RVA: 0x0042C930 File Offset: 0x0042AB30
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckEntityPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntityPositionVerify.<>O.<0>__Verify = new VerifyUnionAction(TRangeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A2D RID: 31277
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F1 RID: 78833
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
