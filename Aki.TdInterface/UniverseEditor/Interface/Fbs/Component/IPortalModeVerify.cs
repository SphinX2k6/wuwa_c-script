using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576E RID: 22382
	public static class IPortalModeVerify
	{
		// Token: 0x06025832 RID: 153650 RVA: 0x0052CC04 File Offset: 0x0052AE04
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

		// Token: 0x02007BE0 RID: 31712
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136A4 RID: 79524
			public static VerifyTableAction <0>__Verify;
		}
	}
}
