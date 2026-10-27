using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D1 RID: 29137
	public static class IStopGuestUiAnimationVerify
	{
		// Token: 0x06033B00 RID: 211712 RVA: 0x006F5AE0 File Offset: 0x006F3CE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStopGuestUiAnimationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStopGuestUiAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IStopGuestCartethyiaVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E72 RID: 32370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A55 RID: 80469
			public static VerifyTableAction <0>__Verify;
		}
	}
}
