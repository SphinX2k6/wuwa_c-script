using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007497 RID: 29847
	public static class IPlayGuestUiAnimationVerify
	{
		// Token: 0x06034411 RID: 214033 RVA: 0x00709894 File Offset: 0x00707A94
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

		// Token: 0x02008682 RID: 34434
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A6E RID: 84590
			public static VerifyTableAction <0>__Verify;
		}
	}
}
