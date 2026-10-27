using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040E7 RID: 16615
	public static class IRoleTowerSystemVarVerify
	{
		// Token: 0x0601836C RID: 99180 RVA: 0x0037CA48 File Offset: 0x0037AC48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRoleTowerSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoleTowerSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200794E RID: 31054
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401326F RID: 78447
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
