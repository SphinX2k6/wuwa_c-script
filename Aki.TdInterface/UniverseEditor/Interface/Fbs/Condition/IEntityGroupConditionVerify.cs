using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005105 RID: 20741
	public static class IEntityGroupConditionVerify
	{
		// Token: 0x060209AA RID: 133546 RVA: 0x00485610 File Offset: 0x00483810
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityGroupConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityGroupConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityEventConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082AF RID: 33455
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014495 RID: 83093
			public static VerifyTableAction <0>__Verify;
		}
	}
}
