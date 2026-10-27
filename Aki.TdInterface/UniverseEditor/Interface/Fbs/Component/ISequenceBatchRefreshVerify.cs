using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FC RID: 22780
	public static class ISequenceBatchRefreshVerify
	{
		// Token: 0x060267E7 RID: 157671 RVA: 0x0054DD00 File Offset: 0x0054BF00
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceBatchRefreshVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceBatchRefreshVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityListBatchVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C28 RID: 31784
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401370E RID: 79630
			public static VerifyTableAction <0>__Verify;
		}
	}
}
