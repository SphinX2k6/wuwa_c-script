using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A7 RID: 18087
	public static class ISkipToQuestNodeVerify
	{
		// Token: 0x0601B7AE RID: 112558 RVA: 0x003E6D4C File Offset: 0x003E4F4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISkipToQuestNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkipToQuestNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IChildQuestConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079D0 RID: 31184
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401336C RID: 78700
			public static VerifyTableAction <0>__Verify;
		}
	}
}
