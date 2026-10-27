using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006301 RID: 25345
	public static class IChangeIconVerify
	{
		// Token: 0x0602BD36 RID: 179510 RVA: 0x00607014 File Offset: 0x00605214
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeIconVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeIconVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D0D RID: 32013
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013871 RID: 79985
			public static VerifyTableAction <0>__Verify;
		}
	}
}
