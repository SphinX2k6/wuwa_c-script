using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004975 RID: 18805
	public static class IBaseAccessQuestDebugDataVerify
	{
		// Token: 0x0601D501 RID: 120065 RVA: 0x00422660 File Offset: 0x00420860
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

		// Token: 0x02007A1E RID: 31262
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133E1 RID: 78817
			public static VerifyTableAction <0>__Verify;
		}
	}
}
