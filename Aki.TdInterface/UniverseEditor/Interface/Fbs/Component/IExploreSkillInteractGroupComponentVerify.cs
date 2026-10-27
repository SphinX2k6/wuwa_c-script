using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051EB RID: 20971
	public static class IExploreSkillInteractGroupComponentVerify
	{
		// Token: 0x060220E5 RID: 139493 RVA: 0x004BA24C File Offset: 0x004B844C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExploreSkillInteractGroupComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExploreSkillInteractGroupComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IExploreSkillInteractVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B12 RID: 31506
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013544 RID: 79172
			public static VerifyTableAction <0>__Verify;
		}
	}
}
