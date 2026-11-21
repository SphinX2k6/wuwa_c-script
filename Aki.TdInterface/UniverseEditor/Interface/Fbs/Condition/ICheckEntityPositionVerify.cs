using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004ED1 RID: 20177
	public static class ICheckEntityPositionVerify
	{
		// Token: 0x0601F513 RID: 128275 RVA: 0x0045D59C File Offset: 0x0045B79C
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

		// Token: 0x0200827C RID: 33404
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401445E RID: 83038
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
