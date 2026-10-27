using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007621 RID: 30241
	public static class Record_Int_IFlowTextConfigVerify
	{
		// Token: 0x0603714F RID: 225615 RVA: 0x0077875C File Offset: 0x0077695C
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

		// Token: 0x02007EDB RID: 32475
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013C2D RID: 80941
			public static VerifyTableAction <0>__Verify;
		}
	}
}
