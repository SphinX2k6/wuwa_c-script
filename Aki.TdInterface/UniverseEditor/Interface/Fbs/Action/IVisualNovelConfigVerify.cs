using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007576 RID: 30070
	public static class IVisualNovelConfigVerify
	{
		// Token: 0x06036B4D RID: 224077 RVA: 0x0076D9B8 File Offset: 0x0076BBB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false))
			{
				short offsetId = 14;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISolarSchoolTimeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007ECA RID: 32458
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C16 RID: 80918
			public static VerifyTableAction <0>__Verify;
		}
	}
}
