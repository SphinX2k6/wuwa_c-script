using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE3 RID: 20195
	public static class ICheckExploreSkillStateVerify
	{
		// Token: 0x0601F59D RID: 128413 RVA: 0x0045E41C File Offset: 0x0045C61C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckExploreSkillStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckExploreSkillStateVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckPlayerAirBubbleEnabledVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200827E RID: 33406
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014460 RID: 83040
			public static VerifyTableAction <0>__Verify;
		}
	}
}
