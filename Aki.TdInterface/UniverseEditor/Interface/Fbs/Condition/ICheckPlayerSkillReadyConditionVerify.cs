using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FDC RID: 20444
	public static class ICheckPlayerSkillReadyConditionVerify
	{
		// Token: 0x0601FE4A RID: 130634 RVA: 0x0046DD74 File Offset: 0x0046BF74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckPlayerSkillReadyConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckPlayerSkillReadyConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TSkillReadyOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008296 RID: 33430
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014479 RID: 83065
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
