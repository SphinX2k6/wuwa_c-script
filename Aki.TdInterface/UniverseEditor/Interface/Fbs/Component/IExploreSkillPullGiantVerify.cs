using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051FA RID: 20986
	public static class IExploreSkillPullGiantVerify
	{
		// Token: 0x06022183 RID: 139651 RVA: 0x004BB5EC File Offset: 0x004B97EC
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

		// Token: 0x02007B14 RID: 31508
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013547 RID: 79175
			public static VerifyTableAction <0>__Verify;
		}
	}
}
