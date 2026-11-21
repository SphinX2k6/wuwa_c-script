using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EF8 RID: 20216
	public static class ICheckGameplayTagConditionVerify
	{
		// Token: 0x0601F658 RID: 128600 RVA: 0x0045F9EC File Offset: 0x0045DBEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckGameplayTagConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckGameplayTagConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008281 RID: 33409
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014463 RID: 83043
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
