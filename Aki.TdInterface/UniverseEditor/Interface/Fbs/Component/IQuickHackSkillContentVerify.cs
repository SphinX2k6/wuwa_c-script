using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D4 RID: 22484
	public static class IQuickHackSkillContentVerify
	{
		// Token: 0x06025C0B RID: 154635 RVA: 0x00534CC0 File Offset: 0x00532EC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IQuickHackSkillContentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IQuickHackSkillContentVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007BF3 RID: 31731
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040136BE RID: 79550
			public static VerifyTableAction <0>__Verify;
		}
	}
}
