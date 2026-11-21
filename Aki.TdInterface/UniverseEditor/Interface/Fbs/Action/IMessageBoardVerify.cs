using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C7 RID: 29127
	public static class IMessageBoardVerify
	{
		// Token: 0x06032A9F RID: 207519 RVA: 0x006D830C File Offset: 0x006D650C
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

		// Token: 0x0200862A RID: 34346
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149FA RID: 84474
			public static VerifyTableAction <0>__Verify;
		}
	}
}
