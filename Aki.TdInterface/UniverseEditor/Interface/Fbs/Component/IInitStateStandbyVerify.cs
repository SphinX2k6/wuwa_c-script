using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B0 RID: 22960
	public static class IInitStateStandbyVerify
	{
		// Token: 0x0602570E RID: 153358 RVA: 0x00522C30 File Offset: 0x00520E30
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

		// Token: 0x020083C7 RID: 33735
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014652 RID: 83538
			public static VerifyTableAction <0>__Verify;
		}
	}
}
