using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2B RID: 27947
	public static class IPlayMontageVerify
	{
		// Token: 0x060314C5 RID: 201925 RVA: 0x006AF908 File Offset: 0x006ADB08
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayMontageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayMontageVerify.<>O.<0>__Verify = new VerifyTableAction(IActionMontageVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DF8 RID: 32248
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139AF RID: 80303
			public static VerifyTableAction <0>__Verify;
		}
	}
}
