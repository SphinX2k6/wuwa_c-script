using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E80 RID: 16000
	public static class IGradingSystemConfigVerify
	{
		// Token: 0x060168D8 RID: 92376 RVA: 0x00342390 File Offset: 0x00340590
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGradingSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGradingSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IGradingSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078EF RID: 30959
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A9 RID: 78249
			public static VerifyTableAction <0>__Verify;
		}
	}
}
