using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF5 RID: 16117
	public static class IKurotatoSystemVarVerify
	{
		// Token: 0x06016CE3 RID: 93411 RVA: 0x0034A1F0 File Offset: 0x003483F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IKurotatoSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IKurotatoSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078FF RID: 30975
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131BF RID: 78271
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
