using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E2C RID: 20012
	public static class IBaseAccessQuestDebugDataVerify
	{
		// Token: 0x0601EF26 RID: 126758 RVA: 0x00452B14 File Offset: 0x00450D14
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBaseAccessQuestDebugDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBaseAccessQuestDebugDataVerify.<>O.<0>__Verify = new VerifyTableAction(IAccessQuestConditionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200826D RID: 33389
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401444E RID: 83022
			public static VerifyTableAction <0>__Verify;
		}
	}
}
