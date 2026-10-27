using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FA0 RID: 16288
	public static class IPlaybackShowTimelineQuestConditionVerify
	{
		// Token: 0x0601745F RID: 95327 RVA: 0x0035B200 File Offset: 0x00359400
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPlaybackShowTimelineQuestConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPlaybackShowTimelineQuestConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200791A RID: 31002
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013205 RID: 78341
			public static VerifyTableAction <0>__Verify;
		}
	}
}
