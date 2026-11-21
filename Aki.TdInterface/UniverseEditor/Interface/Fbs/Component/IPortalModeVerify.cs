using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D75 RID: 23925
	public static class IPortalModeVerify
	{
		// Token: 0x06027D52 RID: 163154 RVA: 0x00572D90 File Offset: 0x00570F90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPortalModeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPortalModeVerify.<>O.<0>__Verify = new VerifyTableAction(IPortalRenderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200844E RID: 33870
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014744 RID: 83780
			public static VerifyTableAction <0>__Verify;
		}
	}
}
