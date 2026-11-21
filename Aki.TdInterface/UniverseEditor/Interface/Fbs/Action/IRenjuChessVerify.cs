using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F9 RID: 30201
	public static class IRenjuChessVerify
	{
		// Token: 0x06034FEA RID: 217066 RVA: 0x0071EA18 File Offset: 0x0071CC18
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

		// Token: 0x0200869D RID: 34461
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A90 RID: 84624
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
