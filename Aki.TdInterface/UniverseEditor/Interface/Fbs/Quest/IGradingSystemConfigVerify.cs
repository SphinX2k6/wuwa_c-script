using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BB RID: 17083
	public static class IGradingSystemConfigVerify
	{
		// Token: 0x06017F0F RID: 98063 RVA: 0x0036B114 File Offset: 0x00369314
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGradingSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGradingSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IGradingSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008135 RID: 33077
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014207 RID: 82439
			public static VerifyTableAction <0>__Verify;
		}
	}
}
