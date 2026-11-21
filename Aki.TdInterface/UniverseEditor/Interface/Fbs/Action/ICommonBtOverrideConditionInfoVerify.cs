using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD5 RID: 27349
	public static class ICommonBtOverrideConditionInfoVerify
	{
		// Token: 0x0602EFCF RID: 192463 RVA: 0x006689EC File Offset: 0x00666BEC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonBtOverrideConditionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtOverrideConditionInfoVerify.<>O.<0>__Verify = new VerifyUnionAction(ICondition2_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085A3 RID: 34211
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014948 RID: 84296
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
