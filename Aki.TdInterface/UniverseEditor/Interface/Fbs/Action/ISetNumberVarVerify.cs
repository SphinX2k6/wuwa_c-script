using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007814 RID: 30740
	public static class ISetNumberVarVerify
	{
		// Token: 0x06036071 RID: 221297 RVA: 0x0073CB8C File Offset: 0x0073AD8C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetNumberVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNumberVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086DF RID: 34527
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AE8 RID: 84712
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
