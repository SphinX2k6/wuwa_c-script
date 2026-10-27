using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BA RID: 28858
	public static class ISheriffCashSettlementVerify
	{
		// Token: 0x060331D1 RID: 209361 RVA: 0x006E4A70 File Offset: 0x006E2C70
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

		// Token: 0x02007E59 RID: 32345
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A30 RID: 80432
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
