using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074A6 RID: 29862
	public static class IPlayMontageVerify
	{
		// Token: 0x060344BD RID: 214205 RVA: 0x0070AF4C File Offset: 0x0070914C
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

		// Token: 0x02008684 RID: 34436
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A73 RID: 84595
			public static VerifyTableAction <0>__Verify;
		}
	}
}
