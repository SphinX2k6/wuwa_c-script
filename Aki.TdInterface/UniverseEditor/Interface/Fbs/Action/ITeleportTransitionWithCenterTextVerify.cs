using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B92 RID: 31634
	public static class ITeleportTransitionWithCenterTextVerify
	{
		// Token: 0x06038FB5 RID: 233397 RVA: 0x007B3864 File Offset: 0x007B1A64
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITeleportTransitionWithCenterTextVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITeleportTransitionWithCenterTextVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008736 RID: 34614
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CAF RID: 85167
			public static VerifyTableAction <0>__Verify;
		}
	}
}
