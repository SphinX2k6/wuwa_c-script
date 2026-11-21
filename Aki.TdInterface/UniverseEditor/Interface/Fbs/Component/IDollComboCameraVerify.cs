using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055F7 RID: 22007
	public static class IDollComboCameraVerify
	{
		// Token: 0x0602310E RID: 143630 RVA: 0x004D3AC0 File Offset: 0x004D1CC0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDollComboCameraVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDollComboCameraVerify.<>O.<0>__Verify = new VerifyTableAction(IDollComboCameraConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200832F RID: 33583
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401455B RID: 83291
			public static VerifyTableAction <0>__Verify;
		}
	}
}
