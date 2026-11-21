using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EBC RID: 20156
	public static class ICheckEntityBuffStackVerify
	{
		// Token: 0x0601F416 RID: 128022 RVA: 0x0045B2B4 File Offset: 0x004594B4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckEntityBuffStackVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckEntityBuffStackVerify.<>O.<0>__Verify = new VerifyTableAction(IMonsterBuffContainerVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008278 RID: 33400
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014459 RID: 83033
			public static VerifyTableAction <0>__Verify;
		}
	}
}
