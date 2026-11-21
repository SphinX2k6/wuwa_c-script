using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200440E RID: 17422
	public static class IQuestBuffActiveRangeVerify
	{
		// Token: 0x06018D87 RID: 101767 RVA: 0x0038B04C File Offset: 0x0038924C
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

		// Token: 0x0200816C RID: 33132
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014280 RID: 82560
			public static VerifyTableAction <0>__Verify;
		}
	}
}
