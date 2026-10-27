using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B01 RID: 19201
	public static class ICheckPlayerSkillReadyConditionVerify
	{
		// Token: 0x0601E309 RID: 123657 RVA: 0x0043BCC8 File Offset: 0x00439EC8
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

		// Token: 0x02007A45 RID: 31301
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401340A RID: 78858
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
