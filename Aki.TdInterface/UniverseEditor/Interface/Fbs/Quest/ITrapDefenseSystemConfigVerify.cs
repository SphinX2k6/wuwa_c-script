using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004696 RID: 18070
	public static class ITrapDefenseSystemConfigVerify
	{
		// Token: 0x0601A889 RID: 108681 RVA: 0x003C6758 File Offset: 0x003C4958
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

		// Token: 0x020081C0 RID: 33216
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014356 RID: 82774
			public static VerifyTableAction <0>__Verify;
		}
	}
}
