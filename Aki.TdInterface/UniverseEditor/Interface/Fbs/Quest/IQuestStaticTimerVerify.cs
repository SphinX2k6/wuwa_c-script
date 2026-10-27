using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200404B RID: 16459
	public static class IQuestStaticTimerVerify
	{
		// Token: 0x06017D6C RID: 97644 RVA: 0x0037055C File Offset: 0x0036E75C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestStaticTimerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStaticTimerVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200793C RID: 31036
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013253 RID: 78419
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
