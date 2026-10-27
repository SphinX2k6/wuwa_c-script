using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423D RID: 16957
	public static class ITrapDefenseSystemVarVerify
	{
		// Token: 0x0601913A RID: 102714 RVA: 0x0039B50C File Offset: 0x0039970C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITrapDefenseSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrapDefenseSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007978 RID: 31096
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132F0 RID: 78576
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
