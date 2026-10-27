using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF8 RID: 19192
	public static class ICheckPlayerPositionVerify
	{
		// Token: 0x0601E2A2 RID: 123554 RVA: 0x0043AE40 File Offset: 0x00439040
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckPlayerPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerPositionVerify.<>O.<0>__Verify = new VerifyUnionAction(TRangeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A42 RID: 31298
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013406 RID: 78854
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
