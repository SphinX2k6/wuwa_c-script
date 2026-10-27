using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E83 RID: 16003
	public static class IGradingSystemVarVerify
	{
		// Token: 0x060168F5 RID: 92405 RVA: 0x0034282C File Offset: 0x00340A2C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IGradingSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGradingSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F0 RID: 30960
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131AA RID: 78250
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
