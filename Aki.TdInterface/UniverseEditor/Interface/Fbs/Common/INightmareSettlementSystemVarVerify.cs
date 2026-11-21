using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200644E RID: 25678
	public static class INightmareSettlementSystemVarVerify
	{
		// Token: 0x0602BA37 RID: 178743 RVA: 0x005F0C34 File Offset: 0x005EEE34
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INightmareSettlementSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INightmareSettlementSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008521 RID: 34081
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014883 RID: 84099
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
