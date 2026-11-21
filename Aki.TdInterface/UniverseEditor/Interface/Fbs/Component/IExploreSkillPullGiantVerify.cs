using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005762 RID: 22370
	public static class IExploreSkillPullGiantVerify
	{
		// Token: 0x06024119 RID: 147737 RVA: 0x004F60B0 File Offset: 0x004F42B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillPullGiantVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillPullGiantVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200836F RID: 33647
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145C7 RID: 83399
			public static VerifyTableAction <0>__Verify;
		}
	}
}
