using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200448C RID: 17548
	public static class IQuestStaticTimerVerify
	{
		// Token: 0x06019405 RID: 103429 RVA: 0x0039A350 File Offset: 0x00398550
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

		// Token: 0x02008183 RID: 33155
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142B6 RID: 82614
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
