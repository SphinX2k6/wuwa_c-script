using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565D RID: 22109
	public static class IDynamicPortalCreatorComponentVerify
	{
		// Token: 0x0602356C RID: 144748 RVA: 0x004DC994 File Offset: 0x004DAB94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicPortalCreatorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicPortalCreatorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicPortalByBulletVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008340 RID: 33600
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401457A RID: 83322
			public static VerifyTableAction <0>__Verify;
		}
	}
}
