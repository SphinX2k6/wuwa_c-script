using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200646D RID: 25709
	public static class ICommonBtOverrideConditionInfoVerify
	{
		// Token: 0x0602C87E RID: 182398 RVA: 0x0061D3E0 File Offset: 0x0061B5E0
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

		// Token: 0x02007D2E RID: 32046
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401389D RID: 80029
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
