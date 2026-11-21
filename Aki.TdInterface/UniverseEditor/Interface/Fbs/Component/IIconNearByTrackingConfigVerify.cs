using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005968 RID: 22888
	public static class IIconNearByTrackingConfigVerify
	{
		// Token: 0x060254E4 RID: 152804 RVA: 0x0051F004 File Offset: 0x0051D204
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IIconNearByTrackingConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IIconNearByTrackingConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020083C0 RID: 33728
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014649 RID: 83529
			public static VerifyTableAction <0>__Verify;
		}
	}
}
