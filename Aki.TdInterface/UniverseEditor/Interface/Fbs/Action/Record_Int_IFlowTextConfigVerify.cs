using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E2F RID: 32303
	public static class Record_Int_IFlowTextConfigVerify
	{
		// Token: 0x0603A5F4 RID: 239092 RVA: 0x007DC858 File Offset: 0x007DAA58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = Record_Int_IFlowTextConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (Record_Int_IFlowTextConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IFlowTextConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008777 RID: 34679
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014D09 RID: 85257
			public static VerifyTableAction <0>__Verify;
		}
	}
}
