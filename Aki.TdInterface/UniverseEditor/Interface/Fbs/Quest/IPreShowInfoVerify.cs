using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FB5 RID: 16309
	public static class IPreShowInfoVerify
	{
		// Token: 0x06017517 RID: 95511 RVA: 0x0035C81C File Offset: 0x0035AA1C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPreShowInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPreShowInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IAccessQuestConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 6, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200791F RID: 31007
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401320C RID: 78348
			public static VerifyTableAction <0>__Verify;
		}
	}
}
