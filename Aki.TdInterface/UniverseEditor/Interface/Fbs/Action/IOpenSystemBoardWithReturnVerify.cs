using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A2 RID: 29602
	public static class IOpenSystemBoardWithReturnVerify
	{
		// Token: 0x06033C40 RID: 212032 RVA: 0x006FBB88 File Offset: 0x006F9D88
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

		// Token: 0x02008668 RID: 34408
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A50 RID: 84560
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
