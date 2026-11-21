using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E6E RID: 20078
	public static class ICheckCurrentRoleVerify
	{
		// Token: 0x0601F190 RID: 127376 RVA: 0x00456E18 File Offset: 0x00455018
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

		// Token: 0x02008271 RID: 33393
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014452 RID: 83026
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
