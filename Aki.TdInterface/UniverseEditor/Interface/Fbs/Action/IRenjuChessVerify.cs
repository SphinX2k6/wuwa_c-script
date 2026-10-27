using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E75 RID: 28277
	public static class IRenjuChessVerify
	{
		// Token: 0x06031FAA RID: 204714 RVA: 0x006C2CE4 File Offset: 0x006C0EE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRenjuChessVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRenjuChessVerify.<>O.<0>__Verify = new VerifyUnionAction(TAdjustPlayerCameraOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E11 RID: 32273
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139CC RID: 80332
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
