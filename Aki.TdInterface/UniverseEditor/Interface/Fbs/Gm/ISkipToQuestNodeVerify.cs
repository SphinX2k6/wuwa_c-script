using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B0F RID: 19215
	public static class ISkipToQuestNodeVerify
	{
		// Token: 0x0601CF83 RID: 118659 RVA: 0x00412FE8 File Offset: 0x004111E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISkipToQuestNodeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISkipToQuestNodeVerify.<>O.<0>__Verify = new VerifyTableAction(IChildQuestConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008219 RID: 33305
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143D3 RID: 82899
			public static VerifyTableAction <0>__Verify;
		}
	}
}
