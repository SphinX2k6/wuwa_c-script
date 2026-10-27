using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200400F RID: 16399
	public static class IQuestRecallDataVerify
	{
		// Token: 0x06017AB7 RID: 96951 RVA: 0x00369F8C File Offset: 0x0036818C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestRecallDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestRecallDataVerify.<>O.<0>__Verify = new VerifyTableAction(IQuestRecallConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007931 RID: 31025
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013240 RID: 78400
			public static VerifyTableAction <0>__Verify;
		}
	}
}
