using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E05 RID: 32261
	public static class IWaitVerify
	{
		// Token: 0x0603A4DC RID: 238812 RVA: 0x007DAEE0 File Offset: 0x007D90E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaitVerify.<>O.<0>__Verify = new VerifyTableAction(IVarIntervalVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008775 RID: 34677
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D07 RID: 85255
			public static VerifyTableAction <0>__Verify;
		}
	}
}
