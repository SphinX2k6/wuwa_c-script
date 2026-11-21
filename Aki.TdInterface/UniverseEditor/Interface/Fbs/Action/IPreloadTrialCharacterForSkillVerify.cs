using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200751E RID: 29982
	public static class IPreloadTrialCharacterForSkillVerify
	{
		// Token: 0x06034956 RID: 215382 RVA: 0x00713B50 File Offset: 0x00711D50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreloadTrialCharacterForSkillVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreloadTrialCharacterForSkillVerify.<>O.<0>__Verify = new VerifyTableAction(ICharacterGroupNewVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008692 RID: 34450
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A85 RID: 84613
			public static VerifyTableAction <0>__Verify;
		}
	}
}
