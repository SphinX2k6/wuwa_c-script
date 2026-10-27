using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681E RID: 26654
	public static class IFlowOpenPhoneMessageVerify
	{
		// Token: 0x0602E765 RID: 190309 RVA: 0x006575C8 File Offset: 0x006557C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFlowOpenPhoneMessageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlowOpenPhoneMessageVerify.<>O.<0>__Verify = new VerifyTableAction(IMessageBoardVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D78 RID: 32120
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138FD RID: 80125
			public static VerifyTableAction <0>__Verify;
		}
	}
}
