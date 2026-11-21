using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D90 RID: 32144
	public static class IVisualNovelPerformanceActivityActionVerify
	{
		// Token: 0x0603A05F RID: 237663 RVA: 0x007D24E0 File Offset: 0x007D06E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelPerformanceActivityActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelPerformanceActivityActionVerify.<>O.<0>__Verify = new VerifyTableAction(IVisualNovelActivityActionSolarSchoolVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008765 RID: 34661
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CF1 RID: 85233
			public static VerifyTableAction <0>__Verify;
		}
	}
}
