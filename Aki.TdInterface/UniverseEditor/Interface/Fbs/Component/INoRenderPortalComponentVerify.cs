using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAE RID: 23470
	public static class INoRenderPortalComponentVerify
	{
		// Token: 0x06026B20 RID: 158496 RVA: 0x0054C194 File Offset: 0x0054A394
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

		// Token: 0x02008408 RID: 33800
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146CC RID: 83660
			public static VerifyTableAction <0>__Verify;
		}
	}
}
