using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200641D RID: 25629
	public static class ICloseFlowTemplateVerify
	{
		// Token: 0x0602C592 RID: 181650 RVA: 0x00615F74 File Offset: 0x00614174
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICloseFlowTemplateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICloseFlowTemplateVerify.<>O.<0>__Verify = new VerifyTableAction(IEndStateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D27 RID: 32039
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013895 RID: 80021
			public static VerifyTableAction <0>__Verify;
		}
	}
}
