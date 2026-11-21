using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043F6 RID: 17398
	public static class IPreShowInfoVerify
	{
		// Token: 0x06018BA6 RID: 101286 RVA: 0x00386434 File Offset: 0x00384634
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

		// Token: 0x02008166 RID: 33126
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401426E RID: 82542
			public static VerifyTableAction <0>__Verify;
		}
	}
}
