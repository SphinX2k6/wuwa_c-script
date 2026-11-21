using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C7 RID: 29895
	public static class IPlayWalkingOverlayRenderMontageVerify
	{
		// Token: 0x06034684 RID: 214660 RVA: 0x0070EA9C File Offset: 0x0070CC9C
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

		// Token: 0x02008689 RID: 34441
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A7C RID: 84604
			public static VerifyTableAction <0>__Verify;
		}
	}
}
