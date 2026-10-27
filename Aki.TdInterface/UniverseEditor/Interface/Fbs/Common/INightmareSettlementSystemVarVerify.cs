using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E11 RID: 24081
	public static class INightmareSettlementSystemVarVerify
	{
		// Token: 0x060293AD RID: 168877 RVA: 0x005A7F04 File Offset: 0x005A6104
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

		// Token: 0x02007CB0 RID: 31920
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137DD RID: 79837
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
