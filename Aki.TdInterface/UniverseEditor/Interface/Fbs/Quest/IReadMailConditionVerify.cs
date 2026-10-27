using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200406F RID: 16495
	public static class IReadMailConditionVerify
	{
		// Token: 0x06017F98 RID: 98200 RVA: 0x00375BD0 File Offset: 0x00373DD0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IReadMailConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReadMailConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007946 RID: 31046
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013263 RID: 78435
			public static VerifyTableAction <0>__Verify;
		}
	}
}
