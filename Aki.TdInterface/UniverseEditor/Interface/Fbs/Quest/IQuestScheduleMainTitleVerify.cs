using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004027 RID: 16423
	public static class IQuestScheduleMainTitleVerify
	{
		// Token: 0x06017BDD RID: 97245 RVA: 0x0036CBA8 File Offset: 0x0036ADA8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IQuestScheduleMainTitleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestScheduleMainTitleVerify.<>O.<0>__Verify = new VerifyUnionAction(TQuestScheduleVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007937 RID: 31031
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401324A RID: 78410
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
