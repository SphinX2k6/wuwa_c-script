using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCB RID: 27851
	public static class IPictureCaptionConfigVerify
	{
		// Token: 0x0603116A RID: 201066 RVA: 0x006A94E4 File Offset: 0x006A76E4
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

		// Token: 0x02007DEB RID: 32235
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401399E RID: 80286
			public static VerifyTableAction <0>__Verify;
		}
	}
}
