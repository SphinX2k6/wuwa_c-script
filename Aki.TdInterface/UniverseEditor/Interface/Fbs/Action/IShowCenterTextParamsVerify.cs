using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DB RID: 28891
	public static class IShowCenterTextParamsVerify
	{
		// Token: 0x060332EA RID: 209642 RVA: 0x006E6704 File Offset: 0x006E4904
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowCenterTextParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowCenterTextParamsVerify.<>O.<0>__Verify = new VerifyTableAction(ITextStyleVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E5B RID: 32347
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A32 RID: 80434
			public static VerifyTableAction <0>__Verify;
		}
	}
}
