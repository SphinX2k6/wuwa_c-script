using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DDB RID: 24027
	public static class IQuickHackSkillContentVerify
	{
		// Token: 0x0602812B RID: 164139 RVA: 0x0057AE4C File Offset: 0x0057904C
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

		// Token: 0x02008461 RID: 33889
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401475E RID: 83806
			public static VerifyTableAction <0>__Verify;
		}
	}
}
