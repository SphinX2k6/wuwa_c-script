using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760E RID: 30222
	public static class IResetFocusConfigVerify
	{
		// Token: 0x06035070 RID: 217200 RVA: 0x0071F8F8 File Offset: 0x0071DAF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IResetFocusConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IResetFocusConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086A1 RID: 34465
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A94 RID: 84628
			public static VerifyTableAction <0>__Verify;
		}
	}
}
