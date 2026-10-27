using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BEB RID: 19435
	public static class IConditionGroupsVerify
	{
		// Token: 0x0601EC38 RID: 126008 RVA: 0x0044F57C File Offset: 0x0044D77C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConditionGroupsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConditionGroupsVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A59 RID: 31321
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013421 RID: 78881
			public static VerifyTableAction <0>__Verify;
		}
	}
}
