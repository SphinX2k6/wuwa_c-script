using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB0 RID: 24240
	public static class ICommonBtConditionInfoVerify
	{
		// Token: 0x06029910 RID: 170256 RVA: 0x005B3D00 File Offset: 0x005B1F00
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

		// Token: 0x02007CBE RID: 31934
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137EE RID: 79854
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
