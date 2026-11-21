using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004450 RID: 17488
	public static class IQuestRecallDataVerify
	{
		// Token: 0x06019150 RID: 102736 RVA: 0x00393D80 File Offset: 0x00391F80
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

		// Token: 0x02008178 RID: 33144
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142A3 RID: 82595
			public static VerifyTableAction <0>__Verify;
		}
	}
}
