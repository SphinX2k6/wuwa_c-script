using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005081 RID: 20609
	public static class ICompareEntityGroupStateConditionVerify
	{
		// Token: 0x060203BD RID: 132029 RVA: 0x00477A9C File Offset: 0x00475C9C
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

		// Token: 0x020082A4 RID: 33444
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401448A RID: 83082
			public static VerifyTableAction <0>__Verify;
		}
	}
}
