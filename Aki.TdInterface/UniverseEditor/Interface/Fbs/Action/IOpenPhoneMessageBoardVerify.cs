using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C17 RID: 27671
	public static class IOpenPhoneMessageBoardVerify
	{
		// Token: 0x06030AA6 RID: 199334 RVA: 0x0069B504 File Offset: 0x00699704
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IOpenPhoneMessageBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenPhoneMessageBoardVerify.<>O.<0>__Verify = new VerifyTableAction(IMessageBoardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DD5 RID: 32213
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401397A RID: 80250
			public static VerifyTableAction <0>__Verify;
		}
	}
}
