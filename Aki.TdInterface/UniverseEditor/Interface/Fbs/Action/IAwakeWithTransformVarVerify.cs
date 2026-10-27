using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D8 RID: 25048
	public static class IAwakeWithTransformVarVerify
	{
		// Token: 0x0602B2C0 RID: 176832 RVA: 0x005F3674 File Offset: 0x005F1874
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

		// Token: 0x02007CF5 RID: 31989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013854 RID: 79956
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
