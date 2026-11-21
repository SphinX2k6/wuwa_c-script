using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006846 RID: 26694
	public static class IAwakeWithTransformVarVerify
	{
		// Token: 0x0602DA07 RID: 186887 RVA: 0x0063E0E8 File Offset: 0x0063C2E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IAwakeWithTransformVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAwakeWithTransformVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008567 RID: 34151
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148FB RID: 84219
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
