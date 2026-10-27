using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F7 RID: 30199
	public static class IWaitVerify
	{
		// Token: 0x06037037 RID: 225335 RVA: 0x00776DE4 File Offset: 0x00774FE4
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

		// Token: 0x02007ED9 RID: 32473
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C2B RID: 80939
			public static VerifyTableAction <0>__Verify;
		}
	}
}
