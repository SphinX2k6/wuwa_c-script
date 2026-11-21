using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005768 RID: 22376
	public static class IExploreSkillQuantumDiffusionVerify
	{
		// Token: 0x06024157 RID: 147799 RVA: 0x004F6878 File Offset: 0x004F4A78
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

		// Token: 0x02008371 RID: 33649
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145C9 RID: 83401
			public static VerifyTableAction <0>__Verify;
		}
	}
}
