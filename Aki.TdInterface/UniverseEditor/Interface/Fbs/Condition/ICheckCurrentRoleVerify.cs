using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049B4 RID: 18868
	public static class ICheckCurrentRoleVerify
	{
		// Token: 0x0601D751 RID: 120657 RVA: 0x004266D0 File Offset: 0x004248D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckCurrentRoleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckCurrentRoleVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A22 RID: 31266
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E5 RID: 78821
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
