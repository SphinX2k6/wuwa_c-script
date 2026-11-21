using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EE2 RID: 16098
	public static class ISystemVarRefVerify
	{
		// Token: 0x06015D35 RID: 89397 RVA: 0x00323DCC File Offset: 0x00321FCC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISystemVarRefVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISystemVarRefVerify.<>O.<0>__Verify = new VerifyUnionAction(TSystemVarVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080C3 RID: 32963
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014143 RID: 82243
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
