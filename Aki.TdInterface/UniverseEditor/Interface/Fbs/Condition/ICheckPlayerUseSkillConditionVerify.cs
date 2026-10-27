using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B07 RID: 19207
	public static class ICheckPlayerUseSkillConditionVerify
	{
		// Token: 0x0601E347 RID: 123719 RVA: 0x0043C50C File Offset: 0x0043A70C
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

		// Token: 0x02007A47 RID: 31303
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401340C RID: 78860
			public static VerifyTableAction <0>__Verify;
		}
	}
}
