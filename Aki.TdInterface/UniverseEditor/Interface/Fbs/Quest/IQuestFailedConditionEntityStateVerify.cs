using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004423 RID: 17443
	public static class IQuestFailedConditionEntityStateVerify
	{
		// Token: 0x06018F35 RID: 102197 RVA: 0x0038EFE9 File Offset: 0x0038D1E9
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

		// Token: 0x02008170 RID: 33136
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014294 RID: 82580
			public static VerifyTableAction <0>__Verify;
		}
	}
}
