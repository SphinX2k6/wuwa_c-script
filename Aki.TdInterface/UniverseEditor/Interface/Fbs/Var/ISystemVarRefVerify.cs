using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AE0 RID: 15072
	public static class ISystemVarRefVerify
	{
		// Token: 0x0601488B RID: 84107 RVA: 0x002FDB3C File Offset: 0x002FBD3C
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

		// Token: 0x02007880 RID: 30848
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130E8 RID: 78056
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
