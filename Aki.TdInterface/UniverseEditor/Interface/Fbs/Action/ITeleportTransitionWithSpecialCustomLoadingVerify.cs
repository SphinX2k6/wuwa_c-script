using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BAA RID: 31658
	public static class ITeleportTransitionWithSpecialCustomLoadingVerify
	{
		// Token: 0x060390A8 RID: 233640 RVA: 0x007B56CC File Offset: 0x007B38CC
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

		// Token: 0x02008739 RID: 34617
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CB7 RID: 85175
			public static VerifyTableAction <0>__Verify;
		}
	}
}
