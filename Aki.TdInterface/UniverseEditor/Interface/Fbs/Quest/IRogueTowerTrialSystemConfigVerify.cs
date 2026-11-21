using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044F8 RID: 17656
	public static class IRogueTowerTrialSystemConfigVerify
	{
		// Token: 0x060198CD RID: 104653 RVA: 0x003A4920 File Offset: 0x003A2B20
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

		// Token: 0x02008192 RID: 33170
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142CF RID: 82639
			public static VerifyTableAction <0>__Verify;
		}
	}
}
