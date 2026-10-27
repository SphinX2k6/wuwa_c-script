using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FCD RID: 16333
	public static class IQuestBuffActiveRangeVerify
	{
		// Token: 0x060176F4 RID: 95988 RVA: 0x00361324 File Offset: 0x0035F524
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestBuffActiveRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestBuffActiveRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IQuestBuffActiveCenterRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyVectorOfData(tablePos, 6, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007925 RID: 31013
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401321D RID: 78365
			public static VerifyTableAction <0>__Verify;
		}
	}
}
