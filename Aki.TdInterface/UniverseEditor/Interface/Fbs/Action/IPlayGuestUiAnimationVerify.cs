using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D1C RID: 27932
	public static class IPlayGuestUiAnimationVerify
	{
		// Token: 0x06031419 RID: 201753 RVA: 0x006AE250 File Offset: 0x006AC450
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayGuestUiAnimationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayGuestUiAnimationVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayGuestCartethyiaVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DF6 RID: 32246
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139AA RID: 80298
			public static VerifyTableAction <0>__Verify;
		}
	}
}
