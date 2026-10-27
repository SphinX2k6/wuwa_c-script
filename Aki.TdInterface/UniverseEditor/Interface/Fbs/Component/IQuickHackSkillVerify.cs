using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D1 RID: 22481
	public static class IQuickHackSkillVerify
	{
		// Token: 0x06025BED RID: 154605 RVA: 0x005348D0 File Offset: 0x00532AD0
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

		// Token: 0x02007BF2 RID: 31730
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136BD RID: 79549
			public static VerifyTableAction <0>__Verify;
		}
	}
}
