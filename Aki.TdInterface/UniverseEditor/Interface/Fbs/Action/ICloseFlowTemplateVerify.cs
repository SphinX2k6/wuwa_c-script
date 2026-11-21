using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A97 RID: 27287
	public static class ICloseFlowTemplateVerify
	{
		// Token: 0x0602ED40 RID: 191808 RVA: 0x00661A88 File Offset: 0x0065FC88
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

		// Token: 0x0200859D RID: 34205
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014941 RID: 84289
			public static VerifyTableAction <0>__Verify;
		}
	}
}
