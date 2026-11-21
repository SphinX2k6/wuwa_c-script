using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007458 RID: 29784
	public static class IPlayDynamicSettlementVerify
	{
		// Token: 0x06034243 RID: 213571 RVA: 0x00706800 File Offset: 0x00704A00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPlayDynamicSettlementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlayDynamicSettlementVerify.<>O.<0>__Verify = new VerifyUnionAction(TDynamicSettlementConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200867B RID: 34427
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A67 RID: 84583
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
