using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FD3 RID: 20435
	public static class ICheckPlayerPositionVerify
	{
		// Token: 0x0601FDE3 RID: 130531 RVA: 0x0046CEEC File Offset: 0x0046B0EC
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

		// Token: 0x02008293 RID: 33427
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014475 RID: 83061
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
