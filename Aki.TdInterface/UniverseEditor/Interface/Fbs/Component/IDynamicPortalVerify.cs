using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050E9 RID: 20713
	public static class IDynamicPortalVerify
	{
		// Token: 0x06021586 RID: 136582 RVA: 0x004A1610 File Offset: 0x0049F810
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicPortalVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicPortalVerify.<>O.<0>__Verify = new VerifyTableAction(IPortalRenderConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AE3 RID: 31459
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134F6 RID: 79094
			public static VerifyTableAction <0>__Verify;
		}
	}
}
