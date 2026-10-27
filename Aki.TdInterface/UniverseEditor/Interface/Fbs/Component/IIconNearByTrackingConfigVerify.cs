using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053E2 RID: 21474
	public static class IIconNearByTrackingConfigVerify
	{
		// Token: 0x0602342C RID: 144428 RVA: 0x004E1FD8 File Offset: 0x004E01D8
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

		// Token: 0x02007B61 RID: 31585
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135C3 RID: 79299
			public static VerifyTableAction <0>__Verify;
		}
	}
}
