using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007441 RID: 29761
	public static class IPictureCaptionConfigVerify
	{
		// Token: 0x06034141 RID: 213313 RVA: 0x00704718 File Offset: 0x00702918
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPictureCaptionConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPictureCaptionConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IUiAnimConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008676 RID: 34422
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A61 RID: 84577
			public static VerifyTableAction <0>__Verify;
		}
	}
}
