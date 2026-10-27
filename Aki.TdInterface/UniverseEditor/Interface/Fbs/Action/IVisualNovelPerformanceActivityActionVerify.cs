using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007597 RID: 30103
	public static class IVisualNovelPerformanceActivityActionVerify
	{
		// Token: 0x06036C2F RID: 224303 RVA: 0x0076EF18 File Offset: 0x0076D118
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

		// Token: 0x02007ECB RID: 32459
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C17 RID: 80919
			public static VerifyTableAction <0>__Verify;
		}
	}
}
