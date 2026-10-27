using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051CD RID: 20941
	public static class IExchangeSlideRailConfigVerify
	{
		// Token: 0x06021F49 RID: 139081 RVA: 0x004B5E9C File Offset: 0x004B409C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExchangeSlideRailConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExchangeSlideRailConfigVerify.<>O.<0>__Verify = new VerifyTableAction(INextSlideRailVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B0B RID: 31499
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013535 RID: 79157
			public static VerifyTableAction <0>__Verify;
		}
	}
}
