using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577A RID: 22394
	public static class IExtraAiAlertVerify
	{
		// Token: 0x060241DF RID: 147935 RVA: 0x004F76BC File Offset: 0x004F58BC
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

		// Token: 0x02008372 RID: 33650
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145CA RID: 83402
			public static VerifyTableAction <0>__Verify;
		}
	}
}
