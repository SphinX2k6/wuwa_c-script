using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C3 RID: 29635
	public static class ITeleportTransitionWithSpecialCustomLoadingVerify
	{
		// Token: 0x06035D0D RID: 220429 RVA: 0x0075318C File Offset: 0x0075138C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportTransitionWithSpecialCustomLoadingVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportTransitionWithSpecialCustomLoadingVerify.<>O.<0>__Verify = new VerifyTableAction(IHonamiStoryCustomLoadingVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007EA0 RID: 32416
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013BDE RID: 80862
			public static VerifyTableAction <0>__Verify;
		}
	}
}
