using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F3 RID: 25843
	public static class ICommonBtConditionInfoVerify
	{
		// Token: 0x0602BFC4 RID: 180164 RVA: 0x005FD1E4 File Offset: 0x005FB3E4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICommonBtConditionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtConditionInfoVerify.<>O.<0>__Verify = new VerifyUnionAction(ICondition2_UnionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200852F RID: 34095
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014894 RID: 84116
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
