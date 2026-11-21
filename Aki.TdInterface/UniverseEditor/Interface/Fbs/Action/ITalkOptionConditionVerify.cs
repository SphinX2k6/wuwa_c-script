using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AFC RID: 31484
	public static class ITalkOptionConditionVerify
	{
		// Token: 0x06038B2A RID: 232234 RVA: 0x007ABAF8 File Offset: 0x007A9CF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITalkOptionConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITalkOptionConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConditionGroupVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200872E RID: 34606
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CA6 RID: 85158
			public static VerifyTableAction <0>__Verify;
		}
	}
}
