using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079A6 RID: 31142
	public static class IStopGuestUiAnimationVerify
	{
		// Token: 0x06036E02 RID: 224770 RVA: 0x00756E40 File Offset: 0x00755040
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

		// Token: 0x02008709 RID: 34569
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B2C RID: 84780
			public static VerifyTableAction <0>__Verify;
		}
	}
}
