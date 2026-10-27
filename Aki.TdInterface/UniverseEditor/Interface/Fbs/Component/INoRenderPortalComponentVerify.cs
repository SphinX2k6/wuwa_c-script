using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005610 RID: 22032
	public static class INoRenderPortalComponentVerify
	{
		// Token: 0x06024910 RID: 149776 RVA: 0x0050BB7C File Offset: 0x00509D7C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INoRenderPortalComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INoRenderPortalComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IStaticNoRenderPortalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BA6 RID: 31654
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401363D RID: 79421
			public static VerifyTableAction <0>__Verify;
		}
	}
}
