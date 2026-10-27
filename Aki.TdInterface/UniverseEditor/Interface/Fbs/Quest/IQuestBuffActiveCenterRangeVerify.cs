using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FCA RID: 16330
	public static class IQuestBuffActiveCenterRangeVerify
	{
		// Token: 0x060176C6 RID: 95942 RVA: 0x00360D40 File Offset: 0x0035EF40
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuestBuffActiveCenterRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuestBuffActiveCenterRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007924 RID: 31012
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401321C RID: 78364
			public static VerifyTableAction <0>__Verify;
		}
	}
}
