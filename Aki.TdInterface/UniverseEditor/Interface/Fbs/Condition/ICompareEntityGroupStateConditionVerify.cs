using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B97 RID: 19351
	public static class ICompareEntityGroupStateConditionVerify
	{
		// Token: 0x0601E811 RID: 124945 RVA: 0x00444F38 File Offset: 0x00443138
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICompareEntityGroupStateConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICompareEntityGroupStateConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityGroupConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A52 RID: 31314
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401341A RID: 78874
			public static VerifyTableAction <0>__Verify;
		}
	}
}
