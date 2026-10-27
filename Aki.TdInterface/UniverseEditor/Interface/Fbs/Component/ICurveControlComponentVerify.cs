using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200504A RID: 20554
	public static class ICurveControlComponentVerify
	{
		// Token: 0x06020F08 RID: 134920 RVA: 0x00494420 File Offset: 0x00492620
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICurveControlComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICurveControlComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IChargeSlashControlVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007ACE RID: 31438
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134CD RID: 79053
			public static VerifyTableAction <0>__Verify;
		}
	}
}
