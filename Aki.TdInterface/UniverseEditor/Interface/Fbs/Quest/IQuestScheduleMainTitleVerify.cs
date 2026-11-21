using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004468 RID: 17512
	public static class IQuestScheduleMainTitleVerify
	{
		// Token: 0x06019276 RID: 103030 RVA: 0x0039699C File Offset: 0x00394B9C
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

		// Token: 0x0200817E RID: 33150
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142AD RID: 82605
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
