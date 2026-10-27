using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049BA RID: 18874
	public static class ICheckDangoCultivationProgressVerify
	{
		// Token: 0x0601D77D RID: 120701 RVA: 0x00426B90 File Offset: 0x00424D90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckDangoCultivationProgressVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckDangoCultivationProgressVerify.<>O.<0>__Verify = new VerifyTableAction(ICountDangoOverTargetLevelVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A23 RID: 31267
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E6 RID: 78822
			public static VerifyTableAction <0>__Verify;
		}
	}
}
