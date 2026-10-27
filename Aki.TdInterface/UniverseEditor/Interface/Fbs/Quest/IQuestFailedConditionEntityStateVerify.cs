using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE2 RID: 16354
	public static class IQuestFailedConditionEntityStateVerify
	{
		// Token: 0x0601789C RID: 96412 RVA: 0x003651F5 File Offset: 0x003633F5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestFailedConditionEntityStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestFailedConditionEntityStateVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityStateConditionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007929 RID: 31017
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013231 RID: 78385
			public static VerifyTableAction <0>__Verify;
		}
	}
}
