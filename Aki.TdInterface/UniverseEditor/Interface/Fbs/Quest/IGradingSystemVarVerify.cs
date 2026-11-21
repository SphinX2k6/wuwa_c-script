using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BE RID: 17086
	public static class IGradingSystemVarVerify
	{
		// Token: 0x06017F2C RID: 98092 RVA: 0x0036B5B0 File Offset: 0x003697B0
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

		// Token: 0x02008136 RID: 33078
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014208 RID: 82440
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
