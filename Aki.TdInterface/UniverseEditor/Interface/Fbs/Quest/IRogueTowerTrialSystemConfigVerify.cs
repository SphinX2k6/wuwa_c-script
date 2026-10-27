using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040B7 RID: 16567
	public static class IRogueTowerTrialSystemConfigVerify
	{
		// Token: 0x0601822C RID: 98860 RVA: 0x0037A9D0 File Offset: 0x00378BD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRogueTowerTrialSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRogueTowerTrialSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRogueTowerTrialSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200794B RID: 31051
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401326C RID: 78444
			public static VerifyTableAction <0>__Verify;
		}
	}
}
