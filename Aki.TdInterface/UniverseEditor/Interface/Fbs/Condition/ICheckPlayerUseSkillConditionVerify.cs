using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FE2 RID: 20450
	public static class ICheckPlayerUseSkillConditionVerify
	{
		// Token: 0x0601FE88 RID: 130696 RVA: 0x0046E5B8 File Offset: 0x0046C7B8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckPlayerUseSkillConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerUseSkillConditionVerify.<>O.<0>__Verify = new VerifyTableAction(ISkillUseTypeRoleSkillVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008298 RID: 33432
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401447B RID: 83067
			public static VerifyTableAction <0>__Verify;
		}
	}
}
