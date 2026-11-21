using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD7 RID: 24535
	public static class IStaticPortalVerify
	{
		// Token: 0x0602952B RID: 169259 RVA: 0x005A4240 File Offset: 0x005A2440
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

		// Token: 0x020084B0 RID: 33968
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147DA RID: 83930
			public static VerifyTableAction <0>__Verify;
		}
	}
}
