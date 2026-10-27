using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A35 RID: 18997
	public static class ICheckGameplayTagConditionVerify
	{
		// Token: 0x0601DBCF RID: 121807 RVA: 0x0042EAF4 File Offset: 0x0042CCF4
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

		// Token: 0x02007A31 RID: 31281
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133F5 RID: 78837
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
