using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D45 RID: 15685
	public static class ICheckActivityStateConditionVerify
	{
		// Token: 0x06015AE6 RID: 88806 RVA: 0x00320CC8 File Offset: 0x0031EEC8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckActivityStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckActivityStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078B5 RID: 30901
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401312D RID: 78125
			public static VerifyTableAction <0>__Verify;
		}
	}
}
