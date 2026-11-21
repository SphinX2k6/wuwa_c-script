using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200564E RID: 22094
	public static class IDynamicPortalVerify
	{
		// Token: 0x060234DA RID: 144602 RVA: 0x004DB59C File Offset: 0x004D979C
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

		// Token: 0x0200833D RID: 33597
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014574 RID: 83316
			public static VerifyTableAction <0>__Verify;
		}
	}
}
