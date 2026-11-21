using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E4 RID: 18148
	public static class IWaitUntilLevelSequenceReachMarkVerify
	{
		// Token: 0x0601AB11 RID: 109329 RVA: 0x003CB368 File Offset: 0x003C9568
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWaitUntilLevelSequenceReachMarkVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWaitUntilLevelSequenceReachMarkVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081C9 RID: 33225
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014362 RID: 82786
			public static VerifyTableAction <0>__Verify;
		}
	}
}
