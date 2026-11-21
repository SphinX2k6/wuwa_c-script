using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DD8 RID: 24024
	public static class IQuickHackSkillVerify
	{
		// Token: 0x0602810D RID: 164109 RVA: 0x0057AA5C File Offset: 0x00578C5C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuickHackSkillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuickHackSkillVerify.<>O.<0>__Verify = new VerifyTableAction(IQuickHackSkillContentVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008460 RID: 33888
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401475D RID: 83805
			public static VerifyTableAction <0>__Verify;
		}
	}
}
