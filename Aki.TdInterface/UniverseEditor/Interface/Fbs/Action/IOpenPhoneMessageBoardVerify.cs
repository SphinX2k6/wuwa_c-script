using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737E RID: 29566
	public static class IOpenPhoneMessageBoardVerify
	{
		// Token: 0x060339FA RID: 211450 RVA: 0x006F5800 File Offset: 0x006F3A00
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

		// Token: 0x0200865F RID: 34399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A3C RID: 84540
			public static VerifyTableAction <0>__Verify;
		}
	}
}
