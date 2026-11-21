using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007886 RID: 30854
	public static class ISheriffCashSettlementVerify
	{
		// Token: 0x06036473 RID: 222323 RVA: 0x0074507C File Offset: 0x0074327C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short typeIdVOffset = 10;
				short valueVOffset = 12;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISheriffCashSettlementVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISheriffCashSettlementVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086EF RID: 34543
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B04 RID: 84740
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
