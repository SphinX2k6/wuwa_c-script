using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059CA RID: 22986
	public static class IStaticPortalVerify
	{
		// Token: 0x06026FB3 RID: 159667 RVA: 0x0055D27C File Offset: 0x0055B47C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IStaticPortalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IStaticPortalVerify.<>O.<0>__Verify = new VerifyTableAction(IPortalRenderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C41 RID: 31809
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013736 RID: 79670
			public static VerifyTableAction <0>__Verify;
		}
	}
}
