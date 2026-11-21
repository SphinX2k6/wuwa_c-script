using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773D RID: 30525
	public static class ISendPhoneMessageVerify
	{
		// Token: 0x060358F0 RID: 219376 RVA: 0x0072DB74 File Offset: 0x0072BD74
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

		// Token: 0x020086BA RID: 34490
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AB3 RID: 84659
			public static VerifyTableAction <0>__Verify;
		}
	}
}
