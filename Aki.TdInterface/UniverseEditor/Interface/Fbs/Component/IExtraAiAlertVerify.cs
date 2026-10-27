using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005212 RID: 21010
	public static class IExtraAiAlertVerify
	{
		// Token: 0x06022249 RID: 139849 RVA: 0x004BCBF8 File Offset: 0x004BADF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IExtraAiAlertVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IExtraAiAlertVerify.<>O.<0>__Verify = new VerifyTableAction(IStateAlertVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B17 RID: 31511
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401354A RID: 79178
			public static VerifyTableAction <0>__Verify;
		}
	}
}
