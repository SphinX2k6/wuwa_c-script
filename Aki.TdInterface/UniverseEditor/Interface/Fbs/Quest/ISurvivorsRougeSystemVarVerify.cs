using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B5 RID: 17845
	public static class ISurvivorsRougeSystemVarVerify
	{
		// Token: 0x0601A08E RID: 106638 RVA: 0x003B5DE8 File Offset: 0x003B3FE8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISurvivorsRougeSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISurvivorsRougeSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081A1 RID: 33185
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401430A RID: 82698
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
