using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E9E RID: 28318
	public static class IFlowOpenPhoneMessageVerify
	{
		// Token: 0x06030FC1 RID: 200641 RVA: 0x006A5100 File Offset: 0x006A3300
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

		// Token: 0x020085EF RID: 34287
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149AA RID: 84394
			public static VerifyTableAction <0>__Verify;
		}
	}
}
