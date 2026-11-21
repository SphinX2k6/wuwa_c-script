using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043E1 RID: 17377
	public static class IPlaybackShowTimelineQuestConditionVerify
	{
		// Token: 0x06018AEE RID: 101102 RVA: 0x00384E18 File Offset: 0x00383018
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

		// Token: 0x02008161 RID: 33121
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014267 RID: 82535
			public static VerifyTableAction <0>__Verify;
		}
	}
}
