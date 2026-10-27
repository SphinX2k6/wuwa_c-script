using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AA2 RID: 27298
	public static class IMessageBoardVerify
	{
		// Token: 0x0602FD63 RID: 195939 RVA: 0x0068204C File Offset: 0x0068024C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMessageBoardVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMessageBoardVerify.<>O.<0>__Verify = new VerifyTableAction(IPhoneMessageBoardConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DA7 RID: 32167
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013941 RID: 80193
			public static VerifyTableAction <0>__Verify;
		}
	}
}
