using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200404E RID: 16462
	public static class IQuestStatisticsVerify
	{
		// Token: 0x06017D9C RID: 97692 RVA: 0x00370F60 File Offset: 0x0036F160
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfData(tablePos, 4, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestStatisticsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestStatisticsVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonCalculateVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200793D RID: 31037
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013254 RID: 78420
			public static VerifyTableAction <0>__Verify;
		}
	}
}
