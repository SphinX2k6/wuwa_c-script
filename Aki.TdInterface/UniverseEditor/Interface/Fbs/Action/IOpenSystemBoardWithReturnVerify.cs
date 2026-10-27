using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C3B RID: 27707
	public static class IOpenSystemBoardWithReturnVerify
	{
		// Token: 0x06030CE7 RID: 199911 RVA: 0x006A16C8 File Offset: 0x0069F8C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenSystemBoardWithReturnVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSystemBoardWithReturnVerify.<>O.<0>__Verify = new VerifyUnionAction(TOpenSystemBoardWithReturnVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DDE RID: 32222
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401398E RID: 80270
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
