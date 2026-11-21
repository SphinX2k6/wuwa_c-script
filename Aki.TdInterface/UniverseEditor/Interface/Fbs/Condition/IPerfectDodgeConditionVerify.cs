using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005168 RID: 20840
	public static class IPerfectDodgeConditionVerify
	{
		// Token: 0x06020C96 RID: 134294 RVA: 0x0048A35C File Offset: 0x0048855C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPerfectDodgeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerfectDodgeConditionVerify.<>O.<0>__Verify = new VerifyUnionAction(TOnlinePlayerConditionTargetVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082B5 RID: 33461
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401449B RID: 83099
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
