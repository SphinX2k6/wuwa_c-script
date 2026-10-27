using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005200 RID: 20992
	public static class IExploreSkillQuantumDiffusionVerify
	{
		// Token: 0x060221C1 RID: 139713 RVA: 0x004BBDB4 File Offset: 0x004B9FB4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillQuantumDiffusionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillQuantumDiffusionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B16 RID: 31510
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013549 RID: 79177
			public static VerifyTableAction <0>__Verify;
		}
	}
}
