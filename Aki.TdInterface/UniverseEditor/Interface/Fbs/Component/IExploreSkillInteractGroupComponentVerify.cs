using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005753 RID: 22355
	public static class IExploreSkillInteractGroupComponentVerify
	{
		// Token: 0x06024079 RID: 147577 RVA: 0x004F4CCC File Offset: 0x004F2ECC
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

		// Token: 0x0200836D RID: 33645
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145C4 RID: 83396
			public static VerifyTableAction <0>__Verify;
		}
	}
}
