using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F8 RID: 22520
	public static class IFollowDecorationComponentVerify
	{
		// Token: 0x060246B9 RID: 149177 RVA: 0x00501420 File Offset: 0x004FF620
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFollowDecorationComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFollowDecorationComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IFollowDecorationChairConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008386 RID: 33670
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145E7 RID: 83431
			public static VerifyTableAction <0>__Verify;
		}
	}
}
