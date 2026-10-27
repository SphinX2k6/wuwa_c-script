using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542A RID: 21546
	public static class IInitStateStandbyVerify
	{
		// Token: 0x06023656 RID: 144982 RVA: 0x004E5C04 File Offset: 0x004E3E04
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 6, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInitStateStandbyVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInitStateStandbyVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 12, 2UL, 2UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B68 RID: 31592
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135CC RID: 79308
			public static VerifyTableAction <0>__Verify;
		}
	}
}
