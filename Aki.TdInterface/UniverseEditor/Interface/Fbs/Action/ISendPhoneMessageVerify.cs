using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F77 RID: 28535
	public static class ISendPhoneMessageVerify
	{
		// Token: 0x060326A0 RID: 206496 RVA: 0x006CE1BC File Offset: 0x006CC3BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISendPhoneMessageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISendPhoneMessageVerify.<>O.<0>__Verify = new VerifyTableAction(IPhoneRecordActionConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E26 RID: 32294
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139E3 RID: 80355
			public static VerifyTableAction <0>__Verify;
		}
	}
}
