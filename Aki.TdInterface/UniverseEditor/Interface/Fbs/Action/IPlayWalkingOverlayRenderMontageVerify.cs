using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4C RID: 27980
	public static class IPlayWalkingOverlayRenderMontageVerify
	{
		// Token: 0x06031688 RID: 202376 RVA: 0x006B33B4 File Offset: 0x006B15B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlayWalkingOverlayRenderMontageVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayWalkingOverlayRenderMontageVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DFD RID: 32253
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139B8 RID: 80312
			public static VerifyTableAction <0>__Verify;
		}
	}
}
