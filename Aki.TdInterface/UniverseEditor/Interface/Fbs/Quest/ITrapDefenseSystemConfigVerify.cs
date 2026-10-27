using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200423A RID: 16954
	public static class ITrapDefenseSystemConfigVerify
	{
		// Token: 0x0601911D RID: 102685 RVA: 0x0039B080 File Offset: 0x00399280
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrapDefenseSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrapDefenseSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ITrapDefenseSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007977 RID: 31095
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132EF RID: 78575
			public static VerifyTableAction <0>__Verify;
		}
	}
}
