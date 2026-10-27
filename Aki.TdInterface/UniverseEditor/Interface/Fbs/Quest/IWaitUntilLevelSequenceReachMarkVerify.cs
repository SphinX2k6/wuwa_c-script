using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004288 RID: 17032
	public static class IWaitUntilLevelSequenceReachMarkVerify
	{
		// Token: 0x060193A5 RID: 103333 RVA: 0x0039FC90 File Offset: 0x0039DE90
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

		// Token: 0x02007980 RID: 31104
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132FB RID: 78587
			public static VerifyTableAction <0>__Verify;
		}
	}
}
