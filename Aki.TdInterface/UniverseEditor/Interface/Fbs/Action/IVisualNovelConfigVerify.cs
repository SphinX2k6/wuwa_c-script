using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D6C RID: 32108
	public static class IVisualNovelConfigVerify
	{
		// Token: 0x06039F75 RID: 237429 RVA: 0x007D0F38 File Offset: 0x007CF138
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IVisualNovelConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IVisualNovelConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISolarSchoolTimeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008764 RID: 34660
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CF0 RID: 85232
			public static VerifyTableAction <0>__Verify;
		}
	}
}
